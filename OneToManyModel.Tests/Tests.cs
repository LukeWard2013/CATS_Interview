
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using CATS_Interview;
using CATS_Interview.Services;
using CATS_Interview.View_Models;
using NUnit.Framework;
using CATS_Interview.Controllers;
using CATS_Interview.Model;

namespace OneToManyModel.Tests
{
    
    public class OperatorViewModelTests
    {
        [SetUp]
        public void Setup()
        {
            var app = new MvcApplication();
            
        }
        [Test]
        public void Should_return_ordered_truck_object()
        {
            //Database.SetInitializer<DatabaseContext>(new DatabaseContextInitialiser());
            Database.SetInitializer<DatabaseContext>(null);
            StartupConfig.CreateAutoMapperMaps();
            var context = new DatabaseContext();

            var op = context.Operators.First(o => o.OperatorId == 1);
            var ov = new OperatorViewModel(op, new Service());

            ICollection<Truck> trucks = context.Operators.First(o=>o.OperatorId==1).Trucks;

            //var output = ov.FillOrderedTrucks(trucks, context.TruckWeights);
        }
    }


    public class OperatorUpdateServiceTests
    {
        private OperatorUpdateService _operatorUpdateService;

        public OperatorUpdateServiceTests()
        {
            _operatorUpdateService = new OperatorUpdateService();
        }

        [Test]
        public void Should_remove_contact()
        {
            var contact = new ContactViewModel();
            contact.Delete = true;
            var modelState = new ModelStateDictionary();
            //modelState["Contacts[0]"] = 
        }
    }
}
