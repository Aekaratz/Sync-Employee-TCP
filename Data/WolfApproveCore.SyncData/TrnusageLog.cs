using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class TrnusageLog
    {
        public int UsageLogId { get; set; }
        public int? ActorId { get; set; }
        public string ActorNameTh { get; set; }
        public string ActorNameEn { get; set; }
        public int? ActorPositionId { get; set; }
        public string ActorPositionNameTh { get; set; }
        public string ActorPositionNameEn { get; set; }
        public int? ActorDepartmentId { get; set; }
        public string ActorDepartmentNameEn { get; set; }
        public string ActorDepartmentNameTh { get; set; }
        public string ActionProcess { get; set; }
        public string ActionStatus { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Comment { get; set; }
        public string Platform { get; set; }
        public string Ipaddress { get; set; }
        public string Note01 { get; set; }
        public string Note02 { get; set; }
        public string Note03 { get; set; }
        public string Note04 { get; set; }
        public string Note05 { get; set; }
    }
}
