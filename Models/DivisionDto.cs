using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDataApp.Models
{
    class DivisionDto
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
        public string ParentCompany { get; set; }

    }
}
