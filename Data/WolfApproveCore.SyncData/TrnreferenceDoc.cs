using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnreferenceDoc
    {
        public int RefDocId { get; set; }
        public int? MemoId { get; set; }
        public int? MemoRefDocId { get; set; }
        public string DocumentNo { get; set; }
        public int? TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string MemoSubject { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Seq { get; set; }
        public string ShowColumn { get; set; }
        public decimal? Amount { get; set; }
    }
}
