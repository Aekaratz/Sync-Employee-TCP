using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnlineApprove
    {
        public int LineApproveId { get; set; }
        public int? MemoId { get; set; }
        public int? Seq { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string PositionTh { get; set; }
        public string PositionEn { get; set; }
        public int? SignatureId { get; set; }
        public string SignatureTh { get; set; }
        public string SignatureEn { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
        public int? TemLineId { get; set; }
        public int? ApproveType { get; set; }
        public int? LineApproveSeq { get; set; }
    }
}
