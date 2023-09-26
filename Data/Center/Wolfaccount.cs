using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.Center
{
    public partial class Wolfaccount
    {
        public int Id { get; set; }
        public string ContactCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsVerify { get; set; }
        public string GuidVerify { get; set; }
        public string Note { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
