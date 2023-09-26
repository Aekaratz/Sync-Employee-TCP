using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstuserPermission
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsView { get; set; }
        public int? Seq { get; set; }
    }
}
