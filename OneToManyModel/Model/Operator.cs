using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class Operator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorId { get; set; }
        public int? VosaSiteId { get; set; }
        public int? GroupId { get; set; }

        public bool InUse { get; set; }
        public int UserId { get; set; }

        public string CompanyName { get; set; }
        public string CareOfCompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string TelephoneStd { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxStd { get; set; }
        public string FaxNumber { get; set; }
        public string WebAddress { get; set; }
        public string IntervieweeEmail { get; set; }
        public string CompanyEmail { get; set; }
        public string PafCompanyName { get; set; }
        public string PafAddress1 { get; set; }
        public string PafAddress2 { get; set; }
        public string PafAddress3 { get; set; }
        public string PafAddress4 { get; set; }
        public string PafTown { get; set; }
        public string PafCounty { get; set; }
        public string PafPostcode { get; set; }
        public string PafTelephoneNumber { get; set; }

        public bool Tps { get; set; }

        public byte WorkshopOptionId { get; set; }
        public WorkshopOption WorkshopOption { get; set; }

        public byte BusinessDescriptionOptionId { get; set; }
        public BusinessDescriptionOption BusinessDescriptionOption { get; set; }

        public byte UsedTrucksOrTrailersOptionId { get; set; }
        public UsedTrucksOrTrailersOption UsedTrucksOrTrailersOption { get; set; }

        //public byte RecordStatusId { get; set; }
        //public RecordStatus RecordStatus { get; set; }

        public bool? Below7500Kg { get; set; }
        public DateTime? OLicenseExpiry { get; set; }
        public bool? ApplyingAddress { get; set; }
        public bool? CurrentOLicense { get; set; }
        public bool? InternationalLicense { get; set; }

        public int? SiteTrucks { get; set; }
        public int? LicenceTrucks { get; set; }

        public int? SiteTrailers { get; set; }
        public int? LicenceTrailers { get; set; }
        
        public virtual ICollection<FinanceMethod> FinanceMethods { get; set; }
        public virtual ICollection<AxleCombination> AxleCombinations { get; set; }

        public virtual ICollection<Truck> Trucks { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Call> Calls { get; set; }
    }
}
