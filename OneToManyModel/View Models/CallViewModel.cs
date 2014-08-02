using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CATS_Interview.Model;
using CATS_Interview.Services;

namespace CATS_Interview.View_Models
{
    public class CallViewModel
    {
        private IEnumerable<SelectListItem> _callOutcomes;

        [HiddenInput(DisplayValue = false)]
        public int CallId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int OperatorId { get; set; }

        [DataType(DataType.Date),DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Call Back Date")]
        public DateTime? CallBackDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Operative { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime InterviewStart { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime InterviewEnd { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "You must enter the outcome of the call.")]
        public byte CallOutcomeId { get; set; }
        
        [Display(Name = "Call Outcome")]
        public CallOutcome CallOutcome { get; set; }

        public IEnumerable<SelectListItem> CallOutcomeOptions
        {
            get
            {
                //don't request data from the database if we already have data.
                if (_callOutcomes == null)
                {
                    var service = new Service();
                    _callOutcomes = service.GetDropDownListOptions(new CallOutcome(), "CallOutcomeId", "CallOutcomeText", false);
                }
                return _callOutcomes;
            }
            set { _callOutcomes = value; }
        } 
    }
}