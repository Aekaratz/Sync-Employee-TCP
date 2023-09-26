using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelDataReader;
using SyncDataApp.data.Center;
using SyncDataApp.data.WolfApproveCore.SyncData;
using SyncDataApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;


namespace SyncDataApp
{
    class Program
    {

        private static readonly CenterTContext _wolfcenter = new CenterTContext();
        private static readonly WolfApproveCoreSyncDataContext db = new WolfApproveCoreSyncDataContext();


        static void Main(string[] args)
        {

            List<EmployeeDto> emp = new List<EmployeeDto>();
            string Excelpath = ConfigurationManager.AppSettings["ExcelFile"];


            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = File.Open(Excelpath, FileMode.Open, FileAccess.Read))
                {
                    Logger.DeleteLog();
                    Console.WriteLine("Waiting ........... ");
                    Logger.WriteLog("Start");

                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {

                        int currentTab = 1;
                        do
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                i += 1;
                                if (i == 1)
                                {
                                    continue;
                                }
                                #region
                                //if (currentTab == 1)
                                //{
                                //    var Div_code = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                //    var diviNameTH = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                //    var divnameEN = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                //    var Status = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                //    var AccountId = reader.GetValue(4) != null ? Convert.ToInt32(reader.GetValue(4).ToString()) : 0;
                                //    var ParentCompany = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";


                                //    string[] keywordActive = { "true", "1", "Active" };
                                //    string[] keywordNotActive = { "false", "0", "InActive" };
                                //    bool statusActive = false;
                                //    if (keywordActive.Contains(Status))
                                //    {
                                //        statusActive = true;
                                //    }
                                //    else if (keywordNotActive.Contains(Status))
                                //    {
                                //        statusActive = false;
                                //    }

                                //    ManageDivision(new DivisionDto()
                                //    {
                                //        DivisionCode = Div_code,
                                //        NameTh = diviNameTH,
                                //        NameEn = divnameEN,
                                //        IsActive = statusActive,
                                //        AccountId = AccountId,
                                //        ParentCompany = ParentCompany,
                                //        CreatedBy = "System",
                                //        CreatedDate = DateTime.Today,
                                //        ModifiedBy = "System",
                                //        ModifiedDate = DateTime.Today
                                //    });



                                //}
                                //if (currentTab == 2)
                                //{

                                //    var DepartmentCode = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                //    var DepartmentTH = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                //    var DepartmentEN = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                //    var STATUS = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                //    var AccountId = reader.GetValue(4) != null ? Convert.ToInt32(reader.GetValue(4).ToString()) : 0;
                                //    var company = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                //    var CodeCompany = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";
                                //    var ParentId = reader.GetValue(7) != null ? reader.GetValue(7).ToString() : "";


                                //    string[] keywordActive = { "true", "1", "Active" };
                                //    string[] keywordNotActive = { "false", "0", "InActive" };
                                //    bool statusActive = false;
                                //    if (keywordActive.Contains(STATUS))
                                //    {
                                //        statusActive = true;
                                //    }
                                //    else if (keywordNotActive.Contains(STATUS))
                                //    {
                                //        statusActive = false;
                                //    }

                                //    ManageDepartment(new DepartMentDto()
                                //    {
                                //        DepartmentCode = DepartmentCode,
                                //        NameTh = DepartmentTH,
                                //        NameEn = DepartmentEN,
                                //        CreatedDate = DateTime.Today,
                                //        CreatedBy = "System",
                                //        ModifiedDate = DateTime.Today,
                                //        ModifiedBy = "System",
                                //        IsActive = statusActive,
                                //        AccountId = AccountId,
                                //        CompanyCode = CodeCompany,
                                //        ParenName = ParentId,
                                //        Company = company
                                //    });

                                //    var tempdep = new DepartMentDto()
                                //    {
                                //        DepartmentCode = DepartmentCode,
                                //        NameTh = DepartmentTH,
                                //        NameEn = DepartmentEN,
                                //        CreatedDate = DateTime.Today,
                                //        CreatedBy = "System",
                                //        ModifiedDate = DateTime.Today,
                                //        ModifiedBy = "System",
                                //        IsActive = statusActive,
                                //        AccountId = AccountId,
                                //        CompanyCode = CodeCompany,
                                //        ParenName = ParentId,
                                //        Company=company
                                //    };
                                //    ManageDepartment(tempdep);
                                //    dep.Add(tempdep);


                                //}
                                //else if (currentTab == 3)
                                //{

                                //    var PosLvsTH = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                //    var PosLvsEN = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                //    var PosLvs = reader.GetValue(2) != null ? Convert.ToDecimal(reader.GetValue(2)) : 0.0m;
                                //    var STATUS = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";

                                //    string[] keywordActive = { "true", "1", "Active" };
                                //    string[] keywordNotActive = { "false", "0", "InActive" };
                                //    bool statusActive = false;
                                //    if (keywordActive.Contains(STATUS))
                                //    {
                                //        statusActive = true;
                                //    }
                                //    else if (keywordNotActive.Contains(STATUS))
                                //    {
                                //        statusActive = false;
                                //    }


                                //    ManagePositionLavel(new MstpositionLevel()
                                //    {
                                //        CreatedDate = DateTime.Today,
                                //        CreatedBy = "System",
                                //        ModifiedDate = DateTime.Today,
                                //        ModifiedBy = "System",
                                //        AccountId = 1,
                                //        NameEn = PosLvsEN,
                                //        NameTh = PosLvsTH,
                                //        PositionLevel = PosLvs,
                                //        IsActive = statusActive

                                //    });
                                //}
                                #endregion


                                else if (currentTab == 1)
                                {

                                    if (emp.Count > 0)
                                    {
                                        Console.WriteLine($"Successfully in:{emp.Count.ToString()} Peple ");
                                    }

                                    var WORK_ID = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var Username = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var FULL_NAME_TH = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    var FULL_NAME_EN = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    var LOGIN_EMAIL2 = reader.GetValue(4) != null ? reader.GetValue(4).ToString() : "";
                                    var STATUS = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    var PositionNameEN = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";
                                    var PositionNameTH = reader.GetValue(7) != null ? reader.GetValue(7).ToString() : "";
                                    var PosLvsEN = reader.GetValue(8) != null ? reader.GetValue(8).ToString() : "";
                                    var DeptCode = reader.GetValue(9) != null ? reader.GetValue(9).ToString() : "";
                                    var Positionid = reader.GetValue(10) != null ? reader.GetValue(10).ToString() : "";
                                    var REPORT_TO = reader.GetValue(11) != null ? reader.GetValue(11).ToString() : "";
                                    var DefaultEN = reader.GetValue(12) != null ? reader.GetValue(12).ToString() : "";
                                    var NumberPhone = reader.GetValue(13) != null ? reader.GetValue(13).ToString() : "";
                                    //เชคActive//InActive

                                    string[] keywordActive = { "true", "1", "Active" };
                                    string[] keywordNotActive = { "false", "0", "InActive", "", " " };
                                    bool statusActive = false;
                                    if (keywordActive.Contains(STATUS))
                                    {
                                        statusActive = true;
                                    }
                                    else if (keywordNotActive.Contains(STATUS))
                                    {
                                        statusActive = false;
                                    }
                                    //ดักอีเมลล์localเเยกไปเก็บที่ Center
                                    var LocalAccout = "";
                                    if (WORK_ID.Contains(Username))
                                    {
                                        LocalAccout = LOGIN_EMAIL2;
                                    }

                                    //var str = WORK_ID;
                                    int strLength = WORK_ID.Length;
                                    if (strLength >= 10)
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE EMPID\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t EMAIL: {LOGIN_EMAIL2}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    else if (WORK_ID == "" || WORK_ID == " ")
                                    {

                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE EMPID\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID = "Null"}\tUSERNAME:{Username}\t EMAIL: {LOGIN_EMAIL2}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }

                                    if (FULL_NAME_EN == "" || FULL_NAME_EN == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE NAME EN\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t EMAIL: {LOGIN_EMAIL2}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN = "Null"}");
                                        continue;
                                    }

                                    if (FULL_NAME_TH == "" || FULL_NAME_TH == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE NAME TH\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t EMAIL: {LOGIN_EMAIL2}\t EmployeeName:{FULL_NAME_TH = "Null"}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (Username == "" || Username == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE USERNAME\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username = "Null"}\t EMAIL: {LOGIN_EMAIL2}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (LOGIN_EMAIL2 == "" || LOGIN_EMAIL2 == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE E-MAIL\n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t EMAIL: {LOGIN_EMAIL2 = "Null"}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (DeptCode == "" || DeptCode == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE DEPARTMENT CODE \n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t Deparetment: {DeptCode = "Null"}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (PositionNameEN == "" || PositionNameEN == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE POSITION EN \n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t Position EN: {PositionNameEN = "Null"}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (PositionNameTH == "" || PositionNameTH == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE POSITION TH \n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t Position TH: {PositionNameTH = "Null"}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }
                                    if (PosLvsEN == "" || PosLvsEN == " ")
                                    {
                                        Logger.WriteLog("***************************************************************************************************************************\n");
                                        Logger.WriteLog($"ERRORLISTEMPLOYEE POSITIONLEVEL  \n");
                                        Logger.WriteLog($"EmplyeeCode:{WORK_ID}\tUSERNAME:{Username}\t PositionLV: {PosLvsEN = "Null"}\t EmployeeName:{FULL_NAME_TH}\t{FULL_NAME_EN}");
                                        continue;
                                    }

                                    else
                                    {
                                        ManageAccount(new Wolfaccount()
                                        {

                                            Username = LocalAccout,
                                            IsActive = statusActive,

                                        });

                                        ManagePosition(new PositionLavelDto()
                                        {
                                            NameEn = PositionNameEN,
                                            NameTh = PositionNameTH,
                                            PositionLvsName = PosLvsEN,
                                            IsActive = statusActive,

                                        });

                                        var tmpEmp = new EmployeeDto()
                                        {

                                            EmployeeCode = WORK_ID,
                                            Username = Username,
                                            NameTh = FULL_NAME_TH,
                                            NameEn = FULL_NAME_EN,
                                            Email = LOGIN_EMAIL2,
                                            IsActive = statusActive,
                                            ReportToEmpCode = REPORT_TO,
                                            PositionNameEn = PositionNameEN,
                                            PositionNameTH = PositionNameTH,
                                            DepartmentCode = DeptCode,
                                            //EmpLevel = PosLvsEN,
                                            ADTitle = NumberPhone,
                                            CreatedDate = DateTime.Today,
                                            CreatedBy = "System",
                                            ModifiedDate = DateTime.Today,
                                            ModifiedBy = "System",
                                            AccountId = 1,
                                            Lang = "EN",

                                        };
                                        ManageEmployee(tmpEmp);
                                        emp.Add(tmpEmp);



                                    }

                                    #region
                                    //ManagePositionLavel(new MSTPositionLevel()
                                    //{
                                    //    PositionLevelId = 0,
                                    //    CreatedDate = DateTime.Today,
                                    //    CreatedBy = "System",
                                    //    ModifiedDate = DateTime.Today,
                                    //    ModifiedBy = "System",
                                    //    AccountId = 1,
                                    //    NameEn = PosLvsEN,
                                    //    NameTh = PosLvsEN,
                                    //    IsActive = statusActive

                                    //});

                                    //ManagePosition(new PositionLavelDto()
                                    //{
                                    //    NameEn = PositionNameEN,
                                    //    NameTh = PositionNameTH,
                                    //    IsActive = statusActive,
                                    //    PositionLvsName = PosLvsEN,
                                    //    CompanyCode = Positionid,
                                    //    CreatedDate = DateTime.Today,
                                    //    CreatedBy = "System",
                                    //    ModifiedDate = DateTime.Today,
                                    //    ModifiedBy = "System",
                                    //    AccountId = 1,
                                    //});

                                    #endregion

                                }

                            }
                            currentTab += 1;
                        } while (
                            reader.NextResult()
                        );

                    }
                }

                //อ่านข้อมูล emp ที่เก็บไว้เพื่อตรวจสอบข้อมูล emp ใน excel และ db ว่ามีข้อมูล reportTO ไหม

                foreach (var item in emp)
                {
                    Console.WriteLine($"item in :{emp.Count.ToString()}");
                    ManageEmployee(item);
                }

                Console.WriteLine("success");
                Logger.WriteLog("Success");
                SentEmail.SentToEmail();

            }
            catch (Exception e)
            {

                Logger.WriteLog($"ERROR:{e.Message} \n Detail:{e.InnerException.Message}");
                Console.WriteLine("ERROR!!");

            }

        }
        #region manage
        //static void ManageDivision(DivisionDto divisionDto)
        //{
        //    var data = db.Mstdivisions.FirstOrDefault(a => a.DivisionCode.Equals(divisionDto.DivisionCode));
        //    if (data == null)
        //    {
        //        db.Mstdivisions.Add(new Mstdivision()
        //        {
        //            DivisionCode = divisionDto.DivisionCode,
        //            NameEn = divisionDto.NameEn,
        //            NameTh = divisionDto.NameTh,
        //            IsActive = divisionDto.IsActive,
        //            AccountId = divisionDto.AccountId,
        //            CreatedBy = divisionDto.CreatedBy,
        //            CreatedDate = divisionDto.CreatedDate,
        //            ModifiedBy = divisionDto.ModifiedBy,
        //            ModifiedDate = divisionDto.ModifiedDate,

        //        });

        //    }
        //    else
        //    {
        //        data.DivisionCode = divisionDto.DivisionCode;
        //        data.NameEn = divisionDto.NameEn;
        //        data.NameTh = divisionDto.NameTh;
        //        data.IsActive = divisionDto.IsActive;
        //        data.AccountId = divisionDto.AccountId;
        //        data.CreatedBy = divisionDto.CreatedBy;
        //        data.CreatedDate = divisionDto.CreatedDate;
        //        data.ModifiedBy = data.ModifiedBy;
        //        data.ModifiedDate = divisionDto.ModifiedDate;
        //    }
        //    db.SaveChanges();
        //}
        //static void ManageDepartment(DepartMentDto departmentDto)
        //{
        //    var data = db.Mstdepartments.FirstOrDefault(a => a.DepartmentCode.Equals(departmentDto.DepartmentCode));
        //    //var paren = db.MSTDepartments.FirstOrDefault(a => a.DepartmentCode.Contains(departmentDto.ParenName));
        //    var division = db.Mstdivisions.FirstOrDefault(a => a.DivisionCode.Contains(departmentDto.ParenName));
        //    var parent = db.Mstdepartments.FirstOrDefault(a => a.DepartmentCode.Contains(division.DivisionCode));


        //    if (data == null)
        //    {
        //        db.Mstdepartments.Add(new Mstdepartment()
        //        {
        //            ParentId = parent.DepartmentId,
        //            DivisionId = division.DivisionId,
        //            DepartmentCode = departmentDto.DepartmentCode,
        //            NameTh = departmentDto.NameTh,
        //            NameEn = departmentDto.NameEn,
        //            CreatedDate = departmentDto.CreatedDate,
        //            CreatedBy = departmentDto.CreatedBy,
        //            ModifiedDate = departmentDto.ModifiedDate,
        //            ModifiedBy = departmentDto.ModifiedBy,
        //            IsActive = departmentDto.IsActive,
        //            AccountId = departmentDto.AccountId,
        //            CompanyCode = departmentDto.CompanyCode

        //        });

        //    }
        //    else if (division == null)
        //    {

        //        data.DivisionId = null;
        //        data.DepartmentCode = departmentDto.DepartmentCode;
        //        data.NameTh = departmentDto.NameTh;
        //        data.NameEn = departmentDto.NameEn;
        //        data.CreatedDate = data.CreatedDate;
        //        data.CreatedBy = departmentDto.CreatedBy;
        //        data.ModifiedDate = departmentDto.ModifiedDate;
        //        data.ModifiedBy = departmentDto.ModifiedBy;
        //        data.IsActive = departmentDto.IsActive;
        //        data.AccountId = departmentDto.AccountId;
        //        data.CompanyCode = departmentDto.CompanyCode;
        //    }


        //    else if (parent == null)
        //    {

        //        data.ParentId = null;
        //        data.DivisionId = division.DivisionId;
        //        data.DepartmentCode = departmentDto.DepartmentCode;
        //        data.NameTh = departmentDto.NameTh;
        //        data.NameEn = departmentDto.NameEn;
        //        data.CreatedDate = data.CreatedDate;
        //        data.CreatedBy = departmentDto.CreatedBy;
        //        data.ModifiedDate = departmentDto.ModifiedDate;
        //        data.ModifiedBy = departmentDto.ModifiedBy;
        //        data.IsActive = departmentDto.IsActive;
        //        data.AccountId = departmentDto.AccountId;
        //        data.CompanyCode = departmentDto.CompanyCode;
        //    }

        //    else
        //    {
        //        data.ParentId = parent.DepartmentId;
        //        data.DivisionId = division.DivisionId;
        //        data.DepartmentCode = departmentDto.DepartmentCode;
        //        data.NameTh = departmentDto.NameTh;
        //        data.NameEn = departmentDto.NameEn;
        //        data.CreatedDate = data.CreatedDate;
        //        data.CreatedBy = departmentDto.CreatedBy;
        //        data.ModifiedDate = departmentDto.ModifiedDate;
        //        data.ModifiedBy = departmentDto.ModifiedBy;
        //        data.IsActive = departmentDto.IsActive;
        //        data.AccountId = departmentDto.AccountId;
        //        data.CompanyCode = departmentDto.CompanyCode;

        //    }
        //    db.SaveChanges();
        //}

        //static void ManagePositionLavel(MstpositionLevel positionLevel)
        //{
        //    var data = db.MstpositionLevels.FirstOrDefault(a => a.NameEn.Equals(positionLevel.NameEn) && a.NameTh.Equals(positionLevel.NameTh));
        //    if (data == null)
        //    {
        //        db.MstpositionLevels.Add(positionLevel);
        //    }
        //    else
        //    {
        //        data.NameEn = positionLevel.NameEn;
        //        data.NameTh = positionLevel.NameTh;
        //        data.PositionLevel = positionLevel.PositionLevel;
        //        data.IsActive = positionLevel.IsActive;
        //        data.CreatedDate = positionLevel.CreatedDate;
        //        data.CreatedBy = positionLevel.CreatedBy;
        //        data.ModifiedDate = positionLevel.ModifiedDate;
        //        data.ModifiedBy = positionLevel.ModifiedBy;
        //        data.AccountId = positionLevel.AccountId;
        //    }
        //    db.SaveChanges();

        //}




        #endregion endmanage

        static void ManagePosition(PositionLavelDto positionDto)
        {
            for (int i = 1; i <= 2; i++)
            {
                var data = db.Mstpositions.FirstOrDefault(a => a.NameEn.Equals(positionDto.NameEn));
                var positionLvs = db.MstpositionLevels.FirstOrDefault(a => a.NameEn.Equals(positionDto.PositionLvsName));
                #region
                //if (data == null)
                //{
                //    db.MSTPositionLevels.Add(new MSTPositionLevel()
                //    {
                //        NameEn = positionDto.NameEn,
                //        NameTh = positionDto.NameTh,
                //        CreatedDate = DateTime.Today,
                //        CreatedBy = "System",
                //        ModifiedDate = DateTime.Today,
                //        ModifiedBy = "System",
                //        AccountId = 1,
                //    });

                //}

                //else

                //{
                //    data.NameEn = positionDto.NameEn;
                //    data.NameTh = positionDto.NameTh;
                //    data.CreatedDate = DateTime.Today;
                //    data.CreatedBy = "System";
                //    data.ModifiedDate = DateTime.Today;
                //    data.ModifiedBy = "System";
                //    data.AccountId = 1;
                //}
                //db.SaveChanges();
                #endregion

                if (data == null)
                {

                    db.Mstpositions.Add(new Mstposition()
                    {

                        NameEn = positionDto.NameEn,
                        NameTh = positionDto.NameTh,
                        PositionLevelId = null,
                        IsActive = positionDto.IsActive,
                        CreatedDate = DateTime.Today,
                        CreatedBy = "System",
                        ModifiedDate = DateTime.Today,
                        ModifiedBy = "System",
                        AccountId = 1,
                        CompanyCode = positionDto.CompanyCode,

                    });

                }
                else if (positionLvs == null)
                {

                    data.NameEn = positionDto.NameEn;
                    data.NameTh = positionDto.NameTh;
                    data.PositionLevelId = null;
                    data.IsActive = positionDto.IsActive;
                    data.CreatedDate = DateTime.Today;
                    data.CreatedBy = "System";
                    data.ModifiedDate = DateTime.Today;
                    data.ModifiedBy = "System";
                    data.AccountId = 1;
                    data.CompanyCode = positionDto.CompanyCode;

                }
                else
                {
                    data.NameEn = positionDto.NameEn;
                    data.NameTh = positionDto.NameTh;
                    data.PositionLevelId = positionLvs.PositionLevelId;
                    data.IsActive = positionDto.IsActive;
                    data.CreatedDate = data.CreatedDate;
                    data.CreatedBy = "System";
                    data.ModifiedDate = DateTime.Today;
                    data.ModifiedBy = "System";
                    data.AccountId = 1;
                    data.CompanyCode = positionDto.CompanyCode;
                }
                db.SaveChanges();
            }

        }
        static void ManageEmployee(EmployeeDto employeeDto)
        {
            Mstemployee data = db.Mstemployees.FirstOrDefault(a => a.EmployeeCode.Equals(employeeDto.EmployeeCode));
            //Mstemployee datadivision = db.Mstemployees.FirstOrDefault(a => a.EmployeeCode.Equals(employeeDto.EmployeeCode));
            var position = db.Mstpositions.FirstOrDefault(p => p.NameEn.Equals(employeeDto.PositionNameEn));
            var departmentcode = db.Mstdepartments.FirstOrDefault(d => d.DepartmentCode.Contains(employeeDto.DepartmentCode));
            var reportto = db.Mstemployees.FirstOrDefault(a => a.EmployeeCode.Contains(employeeDto.ReportToEmpCode));
            //var positioLvs = db.MstpositionLevels.FirstOrDefault(a => a.NameEn.Contains(employeeDto.EmpLevel));
            //Mstdepartment department = db.Mstdepartments.FirstOrDefault(a => a.DepartmentId == data.DepartmentId);
            //Mstdepartment division = db.Mstdepartments.FirstOrDefault(a => a.DepartmentId == department.DepartmentId);

            if (data == null)
            {
                db.Mstemployees.Add(new Mstemployee
                {
                    //EmpLevel = employeeDto.EmpLevel,
                    //EmployeeLevel = positioLvs.PositionLevelId,
                    DivisionId = departmentcode.DepartmentId,
                    EmployeeCode = employeeDto.EmployeeCode,
                    Username = employeeDto.Username,
                    NameTh = employeeDto.NameTh,
                    NameEn = employeeDto.NameEn,
                    Email = employeeDto.Email,
                    IsActive = employeeDto.IsActive,
                    ReportToEmpCode = null,
                    PositionId = position.PositionId,
                    DepartmentId = departmentcode.DepartmentId,
                    Adtitle = employeeDto.ADTitle,
                    CreatedDate = DateTime.Today,
                    CreatedBy = "System",
                    ModifiedDate = DateTime.Today,
                    ModifiedBy = "System",
                    AccountId = 1,
                    Lang = "EN"
                });
            }
            else if (reportto == null)
            {
                //data.EmpLevel = employeeDto.EmpLevel;
                //data.EmployeeLevel = positioLvs.PositionLevelId;
                data.DivisionId = departmentcode.DivisionId;
                data.EmpLevel = employeeDto.EmpLevel;
                data.EmployeeCode = employeeDto.EmployeeCode;
                data.Username = employeeDto.Username;
                data.NameTh = employeeDto.NameTh;
                data.NameEn = employeeDto.NameEn;
                data.Email = employeeDto.Email;
                data.IsActive = employeeDto.IsActive;
                data.ReportToEmpCode = null;
                data.PositionId = position.PositionId;
                data.DepartmentId = departmentcode.DepartmentId;
                data.Adtitle = employeeDto.ADTitle;
                data.CreatedDate = data.CreatedDate;
                data.CreatedBy = "System";
                data.ModifiedDate = DateTime.Today;
                data.ModifiedBy = "System";
                data.AccountId = 1;
                data.Lang = "EN";
                data.SignPicPath = data.SignPicPath;
            }

            else
            {
                //data.EmpLevel = employeeDto.EmpLevel;
                //data.EmployeeLevel = positioLvs.PositionLevelId;
                if (departmentcode == null)
                {
                    Logger.WriteLog("***************************************************************************************************************************\n");
                    Logger.WriteLog($"ERRORLISTEMPLOYEE DEPARTMENT IN DATABASE NULL \n");
                    Logger.WriteLog($"EmplyeeCode:{data.EmployeeCode}\tUSERNAME:{data.Username}\t EmployeeName:{data.NameEn}\t{data.NameEn}\t departmemtId: Null Division : Null");
                    data.DivisionId = null;
                    data.EmployeeCode = employeeDto.EmployeeCode;
                    data.Username = employeeDto.Username;
                    data.NameTh = employeeDto.NameTh;
                    data.NameEn = employeeDto.NameEn;
                    data.Email = employeeDto.Email;
                    data.IsActive = employeeDto.IsActive;
                    data.ReportToEmpCode = reportto.EmployeeId.ToString();
                    data.PositionId = position.PositionId;
                    data.DepartmentId = null;
                    data.Adtitle = employeeDto.ADTitle;
                    data.CreatedDate = data.CreatedDate;
                    data.CreatedBy = "System";
                    data.ModifiedDate = DateTime.Today;
                    data.ModifiedBy = "System";
                    data.AccountId = 1;
                    data.Lang = "EN";
                    data.SignPicPath = data.SignPicPath;
                }
                else
                {
                    data.DivisionId = departmentcode.DivisionId;
                    data.EmployeeCode = employeeDto.EmployeeCode;
                    data.Username = employeeDto.Username;
                    data.NameTh = employeeDto.NameTh;
                    data.NameEn = employeeDto.NameEn;
                    data.Email = employeeDto.Email;
                    data.IsActive = employeeDto.IsActive;
                    data.ReportToEmpCode = reportto.EmployeeId.ToString();
                    data.PositionId = position.PositionId;
                    data.DepartmentId = departmentcode.DepartmentId;
                    data.Adtitle = employeeDto.ADTitle;
                    data.CreatedDate = data.CreatedDate;
                    data.CreatedBy = "System";
                    data.ModifiedDate = DateTime.Today;
                    data.ModifiedBy = "System";
                    data.AccountId = 1;
                    data.Lang = "EN";
                    data.SignPicPath = data.SignPicPath;
                }

            }

            db.SaveChanges();
        }



        static void ManageAccount(Wolfaccount wolfAccount)
        {
            string _ContactCode = ConfigurationManager.AppSettings["ContactCode"];
            string _CreatedBy = ConfigurationManager.AppSettings["CreatedBy"];
            string _ModifiedBy = ConfigurationManager.AppSettings["ModifiedBy"];
            string _Password = ConfigurationManager.AppSettings["Password"];
            string _GuidVerify = ConfigurationManager.AppSettings["GuidVerify"];
            var data = _wolfcenter.Wolfaccounts.FirstOrDefault(a => a.Username.Equals(wolfAccount.Username));

            if (data == null)
            {
                _wolfcenter.Wolfaccounts.Add(new Wolfaccount()
                {
                    ContactCode = _ContactCode,
                    Username = wolfAccount.Username,
                    IsVerify = true,
                    IsActive = wolfAccount.IsActive,
                    CreatedBy = _CreatedBy,
                    CreatedDate = DateTime.Today,
                    ModifiedBy = _ModifiedBy,
                    ModifiedDate = DateTime.Today,
                    Password = _Password,
                    GuidVerify = _GuidVerify

                });

            }
            else
            {
                data.ContactCode = _ContactCode;
                data.Username = wolfAccount.Username;
                data.Password = _Password;
                data.GuidVerify = _GuidVerify;
                data.IsVerify = true;
                data.IsActive = true;
                data.CreatedBy = _CreatedBy;
                data.CreatedDate = data.CreatedDate;
                data.ModifiedBy = _ModifiedBy;
                data.ModifiedDate = DateTime.Today;
            }
            _wolfcenter.SaveChanges();

        }

    }


}