using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MsttemLineApprove
    {
        public int TemLineId { get; set; }
        public int? TemplateId { get; set; }
        public int? Seq { get; set; }
        public int? MaxLevelId { get; set; }
        public int? ApprovalMatrixId { get; set; }
        public int? ApproveType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyCode { get; set; }
        public string Conditions { get; set; }
    }
}
