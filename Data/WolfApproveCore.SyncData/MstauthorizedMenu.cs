using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class MstauthorizedMenu
    {
        public int AuMenuId { get; set; }
        public string Process { get; set; }
        public string GroupMenu { get; set; }
        public string SubMenu { get; set; }
        public string ItemMenu { get; set; }
        public int? OrderGroup { get; set; }
        public int? OrderSub { get; set; }
        public int? OrderItem { get; set; }
        public int? InternalUrl { get; set; }
        public string Url { get; set; }
        public string RolesId { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
