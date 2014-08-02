using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CATS_Interview.Services;

namespace CATS_Interview.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        private Service _service = new Service();
        public ActionResult Search()
        {
            return View();
        }

        private PartialViewResult AjaxSearch(string q)
        {
            var operators = _service.GetAnOperatorForInterview();
            return this.PartialView(operators);
        }
    }
}
