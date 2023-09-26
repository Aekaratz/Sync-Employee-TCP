using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnedocumentQueue
    {
        public int QueueId { get; set; }
        public int? MemoId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? GenaratedDate { get; set; }
    }
}
