using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class Mstdivision
    {
        public int DivisionId { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
        public string DivisionCode { get; set; }
    }
}
