using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncDataApp.Models
{
    class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string Username { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public int? PositionId { get; set; }
        public int? DepartmentId { get; set; }
        public string ReportToEmpCode { get; set; }
        public string SignPicPath { get; set; }
        public string Lang { get; set; }
        public int? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ADTitle { get; set; }
        public int? DivisionId { get; set; }
        public string EmpLevel { get; set; }
        public string EMPL_RCD { get; set; }
        public int? EmployeeLevel { get; set; }
        public DateTime? EffectiveDate { get; set; }

        public string PositionNameTH { get; set; }
        public string PositionNameEn { get; set; }
        public string DepartmentCode { get; set; }
    }
}
