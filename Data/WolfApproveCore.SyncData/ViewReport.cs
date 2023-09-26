using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class ViewReport
    {
        public int? ActionHistoryActionId { get; set; }
        public int? ActionHistoryMemoId { get; set; }
        public int? ActionHistoryActorId { get; set; }
        public string ActionHistoryActorName { get; set; }
        public DateTime? ActionHistoryStartDate { get; set; }
        public string ActionHistoryActionProcess { get; set; }
        public DateTime? ActionHistoryActionDate { get; set; }
        public int? ActionHistoryNextApproverId { get; set; }
        public string ActionHistoryNextApproverName { get; set; }
        public string ActionHistoryComment { get; set; }
        public string ActionHistorySignPicPath { get; set; }
        public string ActionHistoryActionStatus { get; set; }
        public int? ActionHistorySignatureId { get; set; }
        public DateTime? ActionHistoryCreatedDate { get; set; }
        public string ActionHistoryCreatedBy { get; set; }
        public bool? ActionHistoryIsActive { get; set; }
        public int? ActionHistoryAccountId { get; set; }
        public int? AttachFileAttachId { get; set; }
        public int? AttachFileActorId { get; set; }
        public string AttachFileActorName { get; set; }
        public DateTime? AttachFileAttachedDate { get; set; }
        public string AttachFileAttachFile { get; set; }
        public string AttachFileFileName { get; set; }
        public string AttachFileFilePath { get; set; }
        public int? AttachFileMemoId { get; set; }
        public int? AttachFileDelegateId { get; set; }
        public DateTime? AttachFileCreatedDate { get; set; }
        public string AttachFileCreatedBy { get; set; }
        public DateTime? AttachFileModifiedDate { get; set; }
        public string AttachFileModifiedBy { get; set; }
        public int? AttachFileAccountId { get; set; }
        public int MemoMemoId { get; set; }
        public string MemoDocumentNo { get; set; }
        public int? MemoTemplateId { get; set; }
        public string MemoTemplateName { get; set; }
        public string MemoTemplateType { get; set; }
        public int? MemoDepartmentId { get; set; }
        public string MemoDocumentCode { get; set; }
        public bool? MemoIsPublic { get; set; }
        public string MemoReportLang { get; set; }
        public string MemoToPerson { get; set; }
        public string MemoTemplateDetail { get; set; }
        public string MemoCcPerson { get; set; }
        public string MemoTemplateSubject { get; set; }
        public string MemoTtextForm { get; set; }
        public string MemoTadvanceForm { get; set; }
        public bool? MemoAutoApprove { get; set; }
        public string MemoAutoApproveWhen { get; set; }
        public bool? MemoApproverCanEdit { get; set; }
        public int? MemoCreatorId { get; set; }
        public string MemoCnameEn { get; set; }
        public string MemoCnameTh { get; set; }
        public int? MemoCpositionId { get; set; }
        public string MemoCpositionTh { get; set; }
        public string MemoCpositionEn { get; set; }
        public int? MemoCdepartmentId { get; set; }
        public string MemoCdepartmentTh { get; set; }
        public string MemoCdepartmentEn { get; set; }
        public int? MemoCdivisionId { get; set; }
        public string MemoCdivisionEn { get; set; }
        public string MemoCdivisionTh { get; set; }
        public int? MemoRequesterId { get; set; }
        public string MemoRequesterCode { get; set; }
        public string MemoRnameTh { get; set; }
        public string MemoRnameEn { get; set; }
        public int? MemoRpositionId { get; set; }
        public string MemoRpositionTh { get; set; }
        public string MemoRpositionEn { get; set; }
        public int? MemoRdepartmentId { get; set; }
        public string MemoRdepartmentTh { get; set; }
        public string MemoRdepartmentEn { get; set; }
        public int? MemoRdivisionId { get; set; }
        public string MemoRdivisionTh { get; set; }
        public string MemoRdivisionEn { get; set; }
        public string MemoMemoSubject { get; set; }
        public string MemoMtextForm { get; set; }
        public string MemoMadvancveForm { get; set; }
        public int? MemoStatusId { get; set; }
        public string MemoStatusName { get; set; }
        public int? MemoCurrentApprovalLevel { get; set; }
        public decimal? MemoAmount { get; set; }
        public DateTime? MemoRequestDate { get; set; }
        public DateTime? MemoCreatedDate { get; set; }
        public string MemoCreatedBy { get; set; }
        public DateTime? MemoModifiedDate { get; set; }
        public string MemoModifiedBy { get; set; }
        public string MemoLastActionBy { get; set; }
        public int? MemoLastStatusId { get; set; }
        public string MemoLastStatusName { get; set; }
        public int? MemoPersonWaitingId { get; set; }
        public string MemoPersonWaiting { get; set; }
        public int? MemoAccountId { get; set; }
        public string MemoCompanyName { get; set; }
        public int? LineApproveLineApproveId { get; set; }
        public int? LineApproveMemoId { get; set; }
        public int? LineApproveSeq { get; set; }
        public int? LineApproveEmployeeId { get; set; }
        public string LineApproveEmployeeCode { get; set; }
        public string LineApproveNameTh { get; set; }
        public string LineApproveNameEn { get; set; }
        public string LineApprovePositionTh { get; set; }
        public string LineApprovePositionEn { get; set; }
        public int? LineApproveSignatureId { get; set; }
        public string LineApproveSignatureTh { get; set; }
        public string LineApproveSignatureEn { get; set; }
        public bool? LineApproveIsActive { get; set; }
        public int? LineApproveAccountId { get; set; }
    }
}
