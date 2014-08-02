using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using CATS_Interview.Model;
using CATS_Interview.View_Models;
using AutoMapper;
namespace CATS_Interview.Services
{
    public class OperatorUpdateService
    {
        private DatabaseContext _db;

        internal void UpdateRemovedContacts(ModelStateDictionary modelState, IEnumerable<ContactViewModel> contactView)
        {
            
            //if (contactView == null) return;
            //var contactIndex = 0;
            //foreach (var contact in contactView)
            //{
            //    if (contact.Delete)
            //    {
            //        var entryToRemove = "Contacts[" + contactIndex + "]";
            //        while (modelState.FirstOrDefault(ms => ms.Key.ToString(CultureInfo.InvariantCulture).StartsWith(entryToRemove)).Value !=null)
            //        {
            //            modelState.Remove(
            //                modelState.FirstOrDefault(
            //                    ms => ms.Key.ToString(CultureInfo.InvariantCulture).StartsWith(entryToRemove)));
            //        }
            //    }
            //    contactIndex++;
            //}
        }

        internal void UpdateOperator(OperatorViewModel operatorViewModel)
        {
            //Set contacts entity state
            _db = new DatabaseContext();
            var operatortoUpdate =
                _db.Operators.Include(o => o.Trucks).Include(o => o.FinanceMethods).Include(o => o.AxleCombinations).Include(o => o.Contacts).FirstOrDefault(id => id.OperatorId == operatorViewModel.OperatorId);

            if (operatortoUpdate == null) return;

            Mapper.Map(operatorViewModel, operatortoUpdate);

            SetContactEntityState(operatorViewModel, operatortoUpdate);

            //Delete all trucks for operator, cascasde deletes is on by default in EF so bodies and chassis deleted too
            DeleteExistingTrucks(operatortoUpdate);

            //Anything with a count > 0 needs adding
            AddTrucksBodiesAndChassis(operatorViewModel);

            //Delete existing finance methods
            foreach (var financeMethod in operatortoUpdate.FinanceMethods.ToList())
            {
                _db.Entry(financeMethod).State = EntityState.Deleted;
            }

            //Add finance methods
            if (operatorViewModel.SelectedFinanceMethodOptions != null)
                foreach (var selectedFinanceMethodOption in operatorViewModel.SelectedFinanceMethodOptions)
                {
                    operatortoUpdate.FinanceMethods.Add(new FinanceMethod { OperatorId = operatorViewModel.OperatorId, FinanceMethodOptionId = (byte)selectedFinanceMethodOption });
                }

            //Delete existing axle combinations
            foreach (var axleCombination in operatortoUpdate.AxleCombinations.ToList())
            {
                _db.Entry(axleCombination).State = EntityState.Deleted;
            }

            //Add Axle Combinations
            if (operatorViewModel.SelectedAxleCombinations != null)
                foreach (var selectedAxleCombination in operatorViewModel.SelectedAxleCombinations)
                {
                    operatortoUpdate.AxleCombinations.Add(new AxleCombination { OperatorId = operatorViewModel.OperatorId, AxleCombinationOptionId = (byte)selectedAxleCombination });
                }

            operatortoUpdate.InUse = false;

            UpdateCall(operatorViewModel, operatortoUpdate);

            _db.SaveChanges();
        }

        private void AddTrucksBodiesAndChassis(OperatorViewModel operatorViewModel)
        {
            foreach (var truck in operatorViewModel.Trucks.Where(t => t.Count > 0))
            {
                //Add truck
                truck.OperatorId = operatorViewModel.OperatorId;
                _db.Entry(truck).State = EntityState.Added;
                _db.Entry(truck.TruckWeight).State = EntityState.Unchanged;

                AddBodyTypes(operatorViewModel, truck);

                var chassisMake = operatorViewModel.ChassisView.First(c => c.ElementWeightId == truck.WeightValueId);
                if (chassisMake.SelectedElements == null) continue; //next foreach itteration

                AddChassisMakes(truck, chassisMake);
            }
        }

        private static void AddChassisMakes(Truck truck, VehicleElementViewModel chassisMake)
        {
            truck.Chassis = new Collection<Chassis>();
            foreach (var chassisMakeId in chassisMake.SelectedElements.ToList())
            {
                truck.Chassis.Add(new Chassis {ChassisMakeId = (byte) chassisMakeId, TruckId = truck.TruckId});
            }
        }

        private static void AddBodyTypes(OperatorViewModel operatorViewModel, Truck truck)
        {
            var bodyType = operatorViewModel.BodyView.First(b => b.ElementWeightId == truck.WeightValueId);
            if (bodyType.SelectedElements != null)
            {
                truck.Bodies = new Collection<Body>();
                foreach (var bodyTypeId in bodyType.SelectedElements.ToList())
                {
                    truck.Bodies.Add(new Body {BodyTypeId = (byte) bodyTypeId, TruckId = truck.TruckId});
                }
            }
        }

        private void DeleteExistingTrucks(Operator operatortoUpdate)
        {
            if (operatortoUpdate != null)
                foreach (var truck in operatortoUpdate.Trucks.ToList())
                {
                    _db.Entry((object) truck).State = EntityState.Deleted;
                }
        }

        private void SetContactEntityState(OperatorViewModel operatorViewModel, Operator operatortoUpdate)
        {
            if (operatorViewModel.Contacts == null) return;
            foreach (var contact in operatorViewModel.Contacts)
            {
                if (contact.ContactId == 0 && !contact.Delete)
                {
                    var newContact = new Contact();
                    Mapper.Map(contact, newContact);

                    if (operatortoUpdate != null) operatortoUpdate.Contacts.Add(newContact);
                    _db.Entry(newContact).State = EntityState.Added;
                }
                else if (contact.ContactId != 0 && contact.Delete)
                {
                    if (operatortoUpdate != null)
                    {
                        var deletedContact =
                            operatortoUpdate.Contacts.FirstOrDefault(
                                contactId => contactId.ContactId == contact.ContactId);
                        _db.Entry(deletedContact).State = EntityState.Deleted;
                    }
                }
                else if (contact.ContactId == 0 && contact.Delete)
                {
                    //Added, then removed again
                }
                else
                {
                    if (operatortoUpdate != null)
                    {
                        var editedContact =
                            operatortoUpdate.Contacts.FirstOrDefault(
                                contactId => contactId.ContactId == contact.ContactId);

                        Mapper.Map(contact, editedContact);
                        _db.Entry(editedContact).State = EntityState.Modified;
                    }
                }
            }
        }

        public void UpdateCall(OperatorViewModel operatorView, Operator operatortoUpdate)
        {
            switch (operatorView.CallViewModel.CallOutcomeId)
            {
                case (byte)CallOutcomeEnum.CompletedInterview:
                    //operatortoUpdate.InterviewCompletedDate = DateTime.Now;
                    break;
            }

            operatorView.CallViewModel.InterviewStart = operatorView.InterviewStart;
            operatorView.CallViewModel.InterviewEnd = DateTime.Now;

            var newCall = new Call();

            Mapper.Map(operatorView.CallViewModel, newCall);

            newCall.CurrentCall = true;
            newCall.InterviewEnd = DateTime.Now;
            newCall.OperatorId = operatorView.OperatorId;

            //Set current call of all calls for operators to false
            if (operatortoUpdate != null)
                foreach (var call in operatortoUpdate.Calls.Where(o => o.OperatorId == operatorView.OperatorId).ToList())
                {
                    call.CurrentCall = false;
                }

            _db.Entry(newCall).State = EntityState.Added;            
        }
    }
}