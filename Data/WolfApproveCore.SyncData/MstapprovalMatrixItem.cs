using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstapprovalMatrixItem
    {
        public int ApproveMatrixItemId { get; set; }
        public int Seq { get; set; }
        public int? ApproveMatrixId { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public int? ApproverId { get; set; }
        public int? PositionLevelId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
    }
}
