using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Mstcompany
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string AddressTh { get; set; }
        public string AddressEn { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string UrlWeb { get; set; }
        public string UrlLogo { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? AccountId { get; set; }
        public string Bucode { get; set; }
    }
}
