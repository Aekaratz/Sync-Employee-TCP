using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Msttemplate
    {
        public int TemplateId { get; set; }
        public string GroupTemplateName { get; set; }
        public string TemplateName { get; set; }
        public int? DepartmentId { get; set; }
        public string DocumentCode { get; set; }
        public bool? IsPublic { get; set; }
        public string ReportLang { get; set; }
        public string TemplateDetail { get; set; }
        public string ToId { get; set; }
        public string CcId { get; set; }
        public string TemplateSubject { get; set; }
        public bool? IsTextForm { get; set; }
        public string TextForm { get; set; }
        public string AdvanceForm { get; set; }
        public bool? AutoApprove { get; set; }
        public string AutoApproveWhen { get; set; }
        public bool? ApproverCanEdit { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public int? AccountId { get; set; }
        public bool? IsPdfshowInfo { get; set; }
        public bool? IsRequesterEditApproval { get; set; }
        public bool? IsFormControl { get; set; }
        public string RoleId { get; set; }
        public string SpecificEmployeeId { get; set; }
        public string SpecificRoleId { get; set; }
        public string RefTemplate { get; set; }
        public string MultiDeptId { get; set; }
        public bool? ReqAttach { get; set; }
        public string RefDocColumn { get; set; }
        public string RefDocDisplay { get; set; }
        public bool? IsCheckAccess { get; set; }
        public bool? IsDefaultLineApprove { get; set; }
    }
}
