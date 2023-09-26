using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstreportTemplate
    {
        public int ReportTemplateId { get; set; }
        public string ReportName { get; set; }
        public string TemplateId { get; set; }
        public string FieldCollection { get; set; }
        public string ReportDescription { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? AccountId { get; set; }
        public string FavoritesItem { get; set; }
        public string RoleId { get; set; }
        public bool? TemplateVersion { get; set; }
        public string RoleEmp { get; set; }
        public bool? Mode { get; set; }
    }
}
