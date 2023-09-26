using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnattachFile
    {
        public int AttachId { get; set; }
        public int? ActorId { get; set; }
        public string ActorName { get; set; }
        public DateTime? AttachedDate { get; set; }
        public string AttachFile { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int? MemoId { get; set; }
        public int? DelegateId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? AccountId { get; set; }
        public bool IsMergePdf { get; set; }
    }
}
