using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class ViewApprovalMatrix
    {
        public int ApproveMatrixId { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int Seq { get; set; }
        public decimal? AmountFrom { get; set; }
        public decimal? AmountTo { get; set; }
        public int? ApproverId { get; set; }
        public int? PositionLevelId { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
    }
}
