using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CATS_Interview.Model;
using CATS_Interview.Services;

namespace CATS_Interview.View_Models
{
    public class ContactViewModel
    {
        private IEnumerable<SelectListItem> _contactPositions;

        [HiddenInput(DisplayValue = false)]
        public int OperatorId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ContactId { get; set; }

        [Required (ErrorMessage = "Contact title must be entered.")]
        public string Title { get; set; }

        public string Initial { get; set; }

        [Required (ErrorMessage = "Contact surname must be entered.")]
        public string Surname { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "The contacts position is required.")]
        public byte ContactPositionId { get; set; }

        [Display(Name = "Contact Position")]
        public IEnumerable<SelectListItem> ContactPositionOptions
        {
            get
            {
                //don't request data from the database if we already have data.
                if (_contactPositions == null)
                {
                    var service = new Service();
                    _contactPositions = service.GetDropDownListOptions(new ContactPosition(), "ContactPositionId","ContactPositionText", true);
                }
                return _contactPositions;
            }
            set { _contactPositions = value; }
        }

        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool Delete { get; set; }
    }
}