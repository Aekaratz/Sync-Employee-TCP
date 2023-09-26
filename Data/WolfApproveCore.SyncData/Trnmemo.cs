using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Trnmemo
    {
        public int MemoId { get; set; }
        public string DocumentNo { get; set; }
        public int? TemplateId { get; set; }
        public string GroupTemplateName { get; set; }
        public string TemplateName { get; set; }
        public string TemplateType { get; set; }
        public int? DepartmentId { get; set; }
        public string DocumentCode { get; set; }
        public bool? IsPublic { get; set; }
        public string ReportLang { get; set; }
        public string TemplateDetail { get; set; }
        public string ToPerson { get; set; }
        public string CcPerson { get; set; }
        public string TemplateSubject { get; set; }
        public string TtextForm { get; set; }
        public string TadvanceForm { get; set; }
        public bool? AutoApprove { get; set; }
        public string AutoApproveWhen { get; set; }
        public bool? ApproverCanEdit { get; set; }
        public int? CreatorId { get; set; }
        public string CnameTh { get; set; }
        public string CnameEn { get; set; }
        public int? CpositionId { get; set; }
        public string CpositionTh { get; set; }
        public string CpositionEn { get; set; }
        public int? CdepartmentId { get; set; }
        public string CdepartmentTh { get; set; }
        public string CdepartmentEn { get; set; }
        public int? CdivisionId { get; set; }
        public string CdivisionTh { get; set; }
        public string CdivisionEn { get; set; }
        public int? RequesterId { get; set; }
        public string RnameTh { get; set; }
        public string RnameEn { get; set; }
        public int? RpositionId { get; set; }
        public string RpositionTh { get; set; }
        public string RpositionEn { get; set; }
        public int? RdepartmentId { get; set; }
        public string RdepartmentTh { get; set; }
        public string RdepartmentEn { get; set; }
        public int? RdivisionId { get; set; }
        public string RdivisionTh { get; set; }
        public string RdivisionEn { get; set; }
        public string MemoSubject { get; set; }
        public string MtextForm { get; set; }
        public string MadvancveForm { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public int? CurrentApprovalLevel { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string LastActionBy { get; set; }
        public int? LastStatusId { get; set; }
        public string LastStatusName { get; set; }
        public int? PersonWaitingId { get; set; }
        public string PersonWaiting { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public bool IsReaded { get; set; }
        public string TemplateApproveId { get; set; }
        public int? CheckEmpId { get; set; }
        public DateTime? SlastartDate { get; set; }
        public DateTime? SlacompletedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
