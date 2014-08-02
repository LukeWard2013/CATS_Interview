using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using CATS_Interview.Services;
using CATS_Interview.View_Models;

namespace CATS_Interview.Model
{
    public class OperatorViewModel
    {
        //To store time of interview start
        [HiddenInput]
        public DateTime InterviewStart { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int OperatorId { get; set; }

        [Display(Name="Is this the address that applied for the licence?")]
        public bool? ApplyingAddress { get; set; }
        public int? LicenceTrucks { get; set; }
        public int? LicenceTrailers { get; set; }
        [MaxLength(255, ErrorMessage = "Company name must be between 1 and 255 characters."), MinLength(1)]
        [Required(ErrorMessage = "Company name must be between 1 and 255 characters.")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Care of Company Name")]
        public string CareOfCompanyName { get; set; }

        [Display(Name = "Address Line 1")]
        [StringLength(100, ErrorMessage = "Address Line 1 must be between 1 and 100 characters."), MinLength(1)]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Display(Name = "Address Line 3")]
        public string Address3 { get; set; }

        [Display(Name = "Address Line 4")]
        public string Address4 { get; set; }

        [Display(Name = "Town")]
        public string Town { get; set; }

        [Display(Name = "County")]
        public string County { get; set; }

        [Display(Name = "Postcode")]
        [RegularExpression(@"^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {0,1}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$", ErrorMessage = "Postcode is not valid.")]
        public string Postcode { get; set; }

        [RegularExpression("[0-9]+", ErrorMessage = "The STD code doesn't look correct?")]
        [Display(Name = "Telephone STD")]
        public string TelephoneStd { get; set; }

        [RegularExpression("[0-9]+", ErrorMessage = "The Telephone number doesn't look correct?")]
        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        [RegularExpression("[0-9]+", ErrorMessage = "The STD code doesn't look correct?")]
        [Display(Name = "Fax STD")]
        public string FaxStd { get; set; }

        [RegularExpression("[0-9]+", ErrorMessage = "The Fax number doesn't look correct?")]
        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        [Url(ErrorMessage = "Invalid URL!")]
        [Display(Name = "Website Address")]
        public string WebAddress { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Display(Name = "Interview Email Address")]
        public string IntervieweeEmail { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Display(Name = "PAF Telephone Number")]
        public string PafTelephoneNumber { get; set; }

        [Required(ErrorMessage="Please select a business activity.")]
        [Display(Name = "What is your main business activity?")]
        public byte BusinessDescriptionOptionId { get; set; }

        [Required(ErrorMessage = "Please select an option for workshop.")]
        [Display(Name = "Do you have your own workshop?")]
        public byte WorkshopOptionId { get; set; }

        [Required(ErrorMessage="Please select an option for the used trucks or trailers question.")]
        [Display(Name = "Do you buy used trucks or trailers?")]
        public byte UsedTrucksOrTrailersOptionId { get; set; }

        [Display(Name="Number of trailers at site")]
        public int? SiteTrailers { get; set; }
        public ICollection<Truck> Trucks { get; set; }

        //public IEnumerable<TruckWeight> Weights { get; set; }
        public IEnumerable<VehicleElementViewModel> BodyView { get; set; }
        public IEnumerable<VehicleElementViewModel> ChassisView { get; set; }
                                           
        public IEnumerable<SelectListItem> UsedTrucksOrTrailersOptions { get; set; }
        public IEnumerable<SelectListItem> BusinessDescriptionOptions { get; set; }
        public IEnumerable<SelectListItem> WorkshopOptions { get; set; }

        //Properties for finance methods
        [Display(Name = "Finance Method Options")]
        public IEnumerable<SelectListItem> FinanceMethodOptions { get; set; }
        [Display(Name = "Finance Methods")]
        public IEnumerable<SelectListItem> FinanceMethodList { get; set; }
        public int[] SelectedFinanceMethodOptions { get; set; }

        //Properties for axle combinations
        [Display(Name = "Axle Combination Options")]
        public IEnumerable<SelectListItem> AxleCombinationOptions { get; set; }
        [Display(Name = "Axle Combinations")]
        public IEnumerable<SelectListItem> AxleCombinationList { get; set; }
        public int[] SelectedAxleCombinations { get; set; }
        
        public ICollection<ContactViewModel> Contacts { get; set; }
        public IList<RelatedCompaniesViewModel> RelatedCompanies { get; set; }
        public CallViewModel CallViewModel { get; set; }

        public int? SelectedRelatedCompany { get; set; }

        //Parameterless constructor keeps model binder happy on postback
        public OperatorViewModel()
        {
        }

        public OperatorViewModel (Operator op, Service service)
        {
            op.Trucks = service.FillOrderedTrucks(op.Trucks, service.GetTruckWeights(),this);

            //Need to use a mapper tool here
            Contacts = new Collection<ContactViewModel>();

            foreach (var contact in op.Contacts)
                Contacts.Add(Mapper.Map<Contact, ContactViewModel>(contact));

            CallViewModel = new CallViewModel();

            /*
             * Todo - create history view
            var call = op.Calls.FirstOrDefault(c => c.CurrentCall==true);
            CallViewModel = new CallViewModel();
            Mapper.CreateMap<Call,CallViewModel>();
            Mapper.Map(call, CallViewModel);

            //Call.CallId = call.CallId;
            //Call.CallBackDate = call.CallBackDate;
            //Call
            //Call.Notes = call.Notes;
            */
            Mapper.Map(op, this);

            WorkshopOptions = service.GetDropDownListOptions(new WorkshopOption(), "WorkshopOptionId", "WorkshopOptionText", true);

            UsedTrucksOrTrailersOptions = service.GetDropDownListOptions(new UsedTrucksOrTrailersOption(),"UsedTrucksOrTrailersOptionId","UsedTrucksOrTrailersOptionText", true);

            BusinessDescriptionOptions = service.GetDropDownListOptions(new BusinessDescriptionOption(),"BusinessDescriptionOptionId","BusinessDescriptionOptionText", true);

            FinanceMethodOptions = service.GetDropDownListOptions(new FinanceMethodOption(), "FinanceMethodOptionId","FinanceMethodOptionText", true);

            FinanceMethodList = new SelectList(op.FinanceMethods, "FinanceMethodOptionId","FinanceMethodOption.FinanceMethodOptionText", true);

            AxleCombinationOptions = service.GetDropDownListOptions(new AxleCombinationOption(),"AxleCombinationOptionId", "AxleCombinationOptionText", true);

            AxleCombinationList = new SelectList(op.AxleCombinations, "AxleCombinationOptionId","AxleCombinationOption.AxleCombinationOptionText", true);

            RelatedCompanies = service.GetRelatedCompaniesFor(op.GroupId).ToList();
        }
    }
}