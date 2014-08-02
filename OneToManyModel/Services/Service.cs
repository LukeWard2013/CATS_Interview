
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using CATS_Interview.Model;
using CATS_Interview.View_Models;

namespace CATS_Interview.Services
{
    public class Service
    {
        private readonly DatabaseContext _context;

        public Service()
        {
            _context = new DatabaseContext();
        }

        public IEnumerable<CallSummary> GetSummaryOfCalls()
        {
            var calls = from c in _context.Calls.ToList()
                        group c by Convert.ToDateTime(c.CallBackDate.ToString()).Date into g
                        select new CallSummary
                        {
                            Date = g.Key,
                            Count = g.Count()
                        };
            return calls;
        }

        public IEnumerable<SelectListItem> GetDropDownListOptions<T>(T entity, string valueColumn, string textColumn, bool addEmptyOption) where T : class
        {
            var list = _context.Set<T>().ToList();

            if (!addEmptyOption)
            {
                return new SelectList(list, valueColumn, textColumn).OrderBy(o => o.Text);
            }
            var defaultItem = Enumerable.Repeat(new SelectListItem {Text = "", Value = ""}, 1);
            return defaultItem.Concat(new SelectList(list, valueColumn, textColumn)).OrderBy(o => o.Text);
        }

        public Operator GetAnOperatorForInterview()
        {
            Operator op;
            if (_context.Isolate.FirstOrDefault() == null)
            {
                op = (from o in _context.Operators
                          join c in _context.Calls on o.OperatorId equals c.OperatorId into withCalls
                          from subOperators in withCalls.DefaultIfEmpty()
                          where
                              (subOperators.CurrentCall == true || subOperators.CurrentCall == null)
                              &&
                              !o.InUse
                              //&&
                              //--(subOperators.CallBackDate <= DateTime.Now || subOperators.CallBackDate == null)
                          select o).FirstOrDefault();
            }
            else
            {
                op = (from o in _context.Operators
                          join c in _context.Calls on o.OperatorId equals c.OperatorId into withCalls
                          join i in _context.Isolate on o.OperatorId equals i.OperatorId
                          from subOperators in withCalls.DefaultIfEmpty()
                          where
                              (subOperators.CurrentCall == true || subOperators.CurrentCall == null)
                              &&
                              !o.InUse
                              &&
                              (subOperators.CallBackDate <= DateTime.Now || subOperators.CallBackDate == null)
                          select o).FirstOrDefault();                
            }

            if(op!=null)
            {
                //op.InUse = true;
                //_context.SaveChanges();
            }
            return op;
        }

        public void UpdateCalls(IEnumerable<DateTime?> selectedCalls, DateTime resetDate)
        {
            var sql = "Update Calls set CallBackDate = CONVERT(datetime,'" + resetDate + "', 103) where ";

            foreach (DateTime? date in selectedCalls)
            {
                sql += "CONVERT(date, CallBackDate) = CONVERT(date, '" + date + "', 103) OR ";
            }

            _context.Database.ExecuteSqlCommand(sql.Substring(0, sql.Length - 3));
        }

        public IEnumerable<RelatedCompaniesViewModel> GetRelatedCompaniesFor(int? groupId)
        {
            var relatedCompanies = _context.Operators.Where(o => o.GroupId == groupId).OrderByDescending(o=>o.ApplyingAddress);
            IEnumerable<RelatedCompaniesViewModel> relatedCompaniesSummary = new List<RelatedCompaniesViewModel>();

            Mapper.CreateMap<Operator, RelatedCompaniesViewModel>();

            Mapper.Map(relatedCompanies, relatedCompaniesSummary);
            return relatedCompaniesSummary;
        }

        public IEnumerable<TruckWeight> GetTruckWeights()
        {
            return _context.TruckWeights;
        }

        //In - trucks from database
        //Out - trucks from database plus empty truck objects at weight where no trucks exist in database, ordered by weight
        public List<Truck> FillOrderedTrucks(ICollection<Truck> trucks, IEnumerable<TruckWeight> weights, OperatorViewModel operatorViewModel)
        {
            var bodyView = new Collection<VehicleElementViewModel>();
            var chassisView = new Collection<VehicleElementViewModel>();

            foreach (var truckWeight in weights)
            {
                if (trucks.All(t => t.WeightValueId != truckWeight.WeightValueId))
                {
                    //Add vehicle at this weight for view to render
                    trucks.Add(new Truck
                        {
                            WeightValueId = truckWeight.WeightValueId,
                            TruckWeight =
                                new TruckWeight
                                    {
                                        WeightValueId = truckWeight.WeightValueId,
                                        WeightValue = truckWeight.WeightValue
                                    }
                        });
                }

                var trucksAtWeight =
                    trucks.FirstOrDefault(weight => weight.TruckWeight.WeightValue == truckWeight.WeightValue);

                if (trucksAtWeight != null && trucksAtWeight.Bodies != null && trucksAtWeight.Bodies.Count>0)
                {
                    var bodies = trucksAtWeight.Bodies.AsEnumerable().Select(b =>new SelectListItem
                                {
                                    Value = b.BodyTypeId.ToString(CultureInfo.InvariantCulture),
                                    Text = b.BodyType.BodyTypeValue
                                });

                    var bv = new VehicleElementViewModel(ElementEnum.Body, truckWeight.WeightValue,
                                                            truckWeight.WeightValueId)
                        {
                            ElementList = bodies
                        };

                    bodyView.Add(bv);
                }
                else
                {
                    //Add empty list box for view to render
                    var bv = new VehicleElementViewModel(ElementEnum.Body, truckWeight.WeightValue,
                                                            truckWeight.WeightValueId)
                        {
                            ElementList = new MultiSelectList(new List<Body>(), "bodyId", "bodyType")
                        };

                    bodyView.Add(bv);
                }

                operatorViewModel.BodyView = bodyView;

                if (trucksAtWeight != null && trucksAtWeight.Chassis != null && trucksAtWeight.Chassis.Count>0)
                {
                    var chassis =
                        trucksAtWeight.Chassis.Select(
                            c =>
                            new SelectListItem
                                {
                                    Value = c.ChassisMakeId.ToString(CultureInfo.InvariantCulture),
                                    Text = c.ChassisMake.ChassisMakeValue
                                });

                    var cv = new VehicleElementViewModel(ElementEnum.Chassis, truckWeight.WeightValue,
                                                            truckWeight.WeightValueId)
                        {
                            ElementList = chassis //= new MultiSelectList(chassis, "chassisId", "chassisMake")
                        };

                    chassisView.Add(cv);
                }
                else
                {
                    var cv = new VehicleElementViewModel(ElementEnum.Chassis, truckWeight.WeightValue,
                                                            truckWeight.WeightValueId)
                        {
                            ElementList = new MultiSelectList(new List<Chassis>(), "chassisId", "chassisMake")
                        };

                    chassisView.Add(cv);
                }
                operatorViewModel.ChassisView = chassisView;
            }
        
            return trucks.OrderBy(w => w.WeightValueId).ToList();
        }
    }
}