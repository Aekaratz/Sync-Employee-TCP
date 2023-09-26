using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrndelegateDetail
    {
        public int DelegateDetialId { get; set; }
        public int? DelegateId { get; set; }
        public int? TemplateId { get; set; }
        public int? MemoId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? AccountId { get; set; }
    }
}
