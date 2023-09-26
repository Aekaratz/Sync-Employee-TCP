using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{
    public partial class ViewEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string Username { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public string Email { get; set; }
        public string CompanyCode { get; set; }
        public bool? IsActive { get; set; }
        public int? PositionId { get; set; }
        public string PositionNameTh { get; set; }
        public string PositionNameEn { get; set; }
        public int? DepartmentId { get; set; }
        public string DepartmentNameTh { get; set; }
        public string DepartmentNameEn { get; set; }
        public string SignPicPath { get; set; }
        public string Lang { get; set; }
        public int? AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string DefaultLang { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ReportToEmpCode { get; set; }
        public int? DivisionId { get; set; }
        public string DivisionNameTh { get; set; }
        public string DivisionNameEn { get; set; }
        public string Adtitle { get; set; }
    }
}
