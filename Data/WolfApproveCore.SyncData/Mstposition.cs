using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Mstposition
    {
        public int PositionId { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? PositionLevelId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? AccountId { get; set; }
        public string CompanyCode { get; set; }
    }
}
