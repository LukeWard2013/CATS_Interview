using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CATS_Interview.Controllers
{
    public class ManageCallDataController : Controller
    {
        //
        // GET: /ManageCallData/
        [HttpGet]
        public ActionResult Index()
        {
            var service = new Services.Service();
            return View(service.GetSummaryOfCalls());
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<DateTime?> selectedCalls, DateTime resetDate)
        {
            var service = new Services.Service();
            try
            {
                if (selectedCalls != null)
                    service.UpdateCalls(selectedCalls, resetDate);
            }
            catch (Exception exception)
            {
                var errorInfo = new HandleErrorInfo(exception, "Interview", "Index");
                return View("Error", errorInfo);
            }
            return View(service.GetSummaryOfCalls());
        }
    }
}
