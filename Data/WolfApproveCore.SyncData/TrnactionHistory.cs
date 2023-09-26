using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnactionHistory
    {
        public int ActionId { get; set; }
        public int? MemoId { get; set; }
        public int? ActorId { get; set; }
        public string ActorName { get; set; }
        public DateTime? StartDate { get; set; }
        public string ActionProcess { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? NextApproverId { get; set; }
        public string NextApproverName { get; set; }
        public string Comment { get; set; }
        public string SignPicPath { get; set; }
        public string ActionStatus { get; set; }
        public int? SignatureId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
        public string Platform { get; set; }
        public string Ipaddress { get; set; }
        public string ActorNameTh { get; set; }
        public string ActorNameEn { get; set; }
        public int? ActorPositionId { get; set; }
        public string ActorPositionNameTh { get; set; }
        public string ActorPositionNameEn { get; set; }
        public int? ActorDepartmentId { get; set; }
        public string ActorDepartmentNameEn { get; set; }
        public string ActorDepartmentNameTh { get; set; }
        public string ListFilePath { get; set; }
        public int? DelegateActorId { get; set; }
        public string DelegateActorNameTh { get; set; }
        public string DelegateActorNameEn { get; set; }
        public int? DelegateActorPositionId { get; set; }
        public string DelegateActorPositionNameTh { get; set; }
        public string DelegateActorPositionNameEn { get; set; }
        public int? DelegateActorDepartmentId { get; set; }
        public string DelegateActorDepartmentNameEn { get; set; }
        public string DelegateActorDepartmentNameTh { get; set; }
        public string HadvancveForm { get; set; }
        public int? ProcessMinute { get; set; }
        public int? LineApproveSeq { get; set; }
    }
}
