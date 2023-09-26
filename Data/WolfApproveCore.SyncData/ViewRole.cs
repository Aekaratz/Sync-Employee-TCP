using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class ViewRole
    {
        public int RoleId { get; set; }
        public string RoleNameTh { get; set; }
        public string RoleNameEn { get; set; }
        public int? EmployeeId { get; set; }
        public string EmpNameEn { get; set; }
        public string EmpNameTh { get; set; }
        public int? Seq { get; set; }
    }
}
