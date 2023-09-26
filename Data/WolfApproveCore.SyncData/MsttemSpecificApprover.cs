using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MsttemSpecificApprover
    {
        public int TemSpecificId { get; set; }
        public int? TemLineId { get; set; }
        public int? Seq { get; set; }
        public int? SpecificTypeId { get; set; }
        public int? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public string Detail { get; set; }
        public int SignatureId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
    }
}
