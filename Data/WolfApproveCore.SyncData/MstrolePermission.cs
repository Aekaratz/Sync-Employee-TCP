using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstrolePermission
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public int AccountId { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsView { get; set; }
    }
}
