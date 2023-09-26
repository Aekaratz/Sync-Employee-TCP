using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstemailTemplate
    {
        public int EmailTemplateId { get; set; }
        public int? TemplateId { get; set; }
        public string FormState { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
