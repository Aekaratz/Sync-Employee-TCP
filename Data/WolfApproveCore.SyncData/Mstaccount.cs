using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Mstaccount
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTrial { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public bool? IsSelfRegis { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? TotalUser { get; set; }
        public string LogoPic { get; set; }
        public string ThemeColor { get; set; }
        public string Lang { get; set; }
        public string Mslicence { get; set; }
    }
}
