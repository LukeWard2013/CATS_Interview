using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;
using CATS_Interview.Model;
using CATS_Interview.Services;

namespace CATS_Interview.Controllers
{
    public class InterviewController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly Service _service;
        private readonly OperatorUpdateService _operatorUpdateService;

        public InterviewController()
        {
            _service=new Service();
            _db=new DatabaseContext();
            _operatorUpdateService = new OperatorUpdateService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                var op = _service.GetAnOperatorForInterview();
                var ov = new OperatorViewModel(op, _service);
                return op == null ? View("NoRecords") : View(ov);
            }
            catch (Exception exception)
            {
                var errorInfo = new HandleErrorInfo(exception, "Interview", "Index");
                return View("Error", errorInfo);
            }
        }

        [HttpPost]
        public ActionResult Save(OperatorViewModel operatorView)
        {
            try
            {
                _operatorUpdateService.UpdateRemovedContacts(ModelState, operatorView.Contacts);

                if (!ModelState.IsValid)
                {
                    var op = RebuildOperatorViewModel(operatorView);
                    return View("../Interview/Index", op);
                }
                _operatorUpdateService.UpdateOperator(operatorView);
            }
            catch (Exception exception)
            {
                var errorInfo = new HandleErrorInfo(exception, "Interview", "Index");
                return View("Error", errorInfo);
            }

             return Redirect("/Interview");
        }

        private OperatorViewModel RebuildOperatorViewModel(OperatorViewModel operatorView)
        {
            operatorView.BusinessDescriptionOptions = new SelectList(_db.BusinessDescriptionOptions, "BusinessDescriptionOptionId", "BusinessDescriptionOptionText", operatorView.BusinessDescriptionOptionId);
            operatorView.WorkshopOptions = new SelectList(_db.WorkshopOptions, "WorkshopOptionId", "WorkshopOptionText", operatorView.WorkshopOptionId);
            operatorView.UsedTrucksOrTrailersOptions = new SelectList(_db.UsedTrucksOrTrailersOptions, "UsedTrucksOrTrailersOptionId", "UsedTrucksOrTrailersOptionText", operatorView.UsedTrucksOrTrailersOptionId);

            //todo build trucks collection from post back (operatorView)
            foreach(var truck in operatorView.Trucks)
            {
                var selectedBodies =
                    operatorView.BodyView.FirstOrDefault(bv => bv.ElementWeightId == truck.WeightValueId);

                if (selectedBodies != null)
                {
                    var bodyTypes =
                        from b in _db.BodyTypes.Where(bt => selectedBodies.SelectedElements.Contains(bt.BodyTypeId))
                        select (new {b.BodyTypeId, b.BodyTypeValue});

                    if (selectedBodies.SelectedElements != null)
                    {
                        truck.Bodies = new Collection<Body>();
                        foreach (var bodyType in bodyTypes)
                        {
                            truck.Bodies.Add(new Body
                                {
                                    BodyTypeId = bodyType.BodyTypeId,
                                    TruckId = truck.TruckId,
                                    BodyType =
                                        new BodyType
                                            {BodyTypeId = bodyType.BodyTypeId, BodyTypeValue = bodyType.BodyTypeValue}
                                });
                        }
                    }
                }
                var selectedChassis =
                    operatorView.ChassisView.FirstOrDefault(cv => cv.ElementWeightId == truck.WeightValueId);

                if (selectedChassis == null) continue;
                var chassisMakes =
                    from c in
                        _db.ChassisMakes.Where(cm => selectedChassis.SelectedElements.Contains(cm.ChassisMakeId))
                    select (new {c.ChassisMakeId, c.ChassisMakeValue});
                if (selectedChassis.SelectedElements == null) continue;
                truck.Chassis = new Collection<Chassis>();
                foreach(var chassisMake in chassisMakes)
                {
                    truck.Chassis.Add(new Chassis
                        {
                            ChassisMakeId = chassisMake.ChassisMakeId,
                            TruckId = truck.TruckId,
                            ChassisMake = new ChassisMake
                                {
                                    ChassisMakeId = chassisMake.ChassisMakeId,
                                    ChassisMakeValue = chassisMake.ChassisMakeValue
                                }
                        });

                }
            }

            operatorView.Trucks = _service.FillOrderedTrucks(operatorView.Trucks, _service.GetTruckWeights(),
                                                                 operatorView);


            operatorView.FinanceMethodOptions = _service.GetDropDownListOptions(new FinanceMethodOption(), "FinanceMethodOptionId", "FinanceMethodOptionText", true);

            if (operatorView.SelectedFinanceMethodOptions == null)
            {
                operatorView.FinanceMethodList = new SelectList(new List<FinanceMethodOption>(), "FinanceMethodOptionId",
                                                                "FinanceMethodOptionText");
            }
            else
            {
                IEnumerable<FinanceMethodOption> postedFinanceMethods = _db.FinanceMethodOptions.Where(
                    f => operatorView.SelectedFinanceMethodOptions.Contains(f.FinanceMethodOptionId)).ToList();
                operatorView.FinanceMethodList = new SelectList(postedFinanceMethods, "FinanceMethodOptionId",
                                                                "FinanceMethodOptionText");
            }


            operatorView.AxleCombinationOptions = _service.GetDropDownListOptions(new AxleCombinationOption(),
                                                                        "AxleCombinationOptionId",
                                                                        "AxleCombinationOptionText", true);

            if(operatorView.SelectedAxleCombinations==null)
            {
                operatorView.AxleCombinationList = new SelectList(new List<AxleCombinationOption>(),
                                                                  "AxleCombinationOptionId", "AxleCombinationOptionText");
            }
            else
            {
                var postedAxelCombinations =
                    _db.AxleCombinationValues.Where(
                        a => operatorView.SelectedAxleCombinations.Contains(a.AxleCombinationOptionId)).ToList();

                operatorView.AxleCombinationList = new SelectList(postedAxelCombinations, "AxleCombinationOptionId", "AxleCombinationOptionText");                
            }



            operatorView.CallViewModel.CallOutcomeOptions = new SelectList(_db.CallOutcomes, "CallOutcomeId", "CallOutcomeText", operatorView.CallViewModel.CallOutcomeId);
            return operatorView;
        }       
    }
}