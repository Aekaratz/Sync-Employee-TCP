using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class ViewRolePermission
    {
        public int MenuId { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string MenuDescription { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsView { get; set; }
        public int? RoleId { get; set; }
        public int? AccountId { get; set; }
        public bool? CheckedCreate { get; set; }
        public bool? CheckedEdit { get; set; }
        public bool? CheckedDelete { get; set; }
        public bool? CheckedView { get; set; }
    }
}
