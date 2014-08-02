using System.ComponentModel.DataAnnotations;

namespace CATS_Interview.View_Models
{
    public class RelatedCompaniesViewModel
    {
        public int OperatorId { get; set; }
        public bool? ApplyingAddress { get; set; }
        public int? SiteTrucks { get; set; }
        public int? LicenceTrucks { get; set; }

        public int? SiteTrailers { get; set; }
        public int? LicenceTrailers { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Care of Company Name")]
        public string CareOfCompanyName { get; set; }

        [Display(Name = "Address Line 1")]
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
        public string Postcode { get; set; }

        [Display(Name = "Telephone STD")]
        public string TelephoneStd { get; set; }

        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        public string SelectedRelatedCompany { get; set; }
    }
}