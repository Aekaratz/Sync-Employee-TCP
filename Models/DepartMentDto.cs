using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDataApp.Models
{
    class DepartMentDto
    {
        public string ParenName { get; set; }
        public int DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public int? DivisionId { get; set; }
        public string DepartmentCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountId { get; set; }
        public int? LeaderId { get; set; }
        public string CompanyCode { get; set; }
        public string Company { get; set; }
    }
}
