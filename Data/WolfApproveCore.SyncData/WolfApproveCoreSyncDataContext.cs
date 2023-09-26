using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SyncDataApp.data.WolfApproveCore.SyncData
{

    public partial class WolfApproveCoreSyncDataContext : DbContext
    {
        string connectionString = ConfigurationManager.ConnectionStrings["WolfAproveTCP"].ConnectionString;
        public WolfApproveCoreSyncDataContext()
        {
        }

        public WolfApproveCoreSyncDataContext(DbContextOptions<WolfApproveCoreSyncDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Mstaccount> Mstaccounts { get; set; }
        public virtual DbSet<MstapprovalMatrix> MstapprovalMatrices { get; set; }
        public virtual DbSet<MstapprovalMatrixItem> MstapprovalMatricesItem { get; set; }
        public virtual DbSet<MstauthorizedMenu> MstauthorizedMenus { get; set; }
        public virtual DbSet<Mstchecklist> Mstchecklists { get; set; }
        public virtual DbSet<Mstcompany> Mstcompanies { get; set; }
        public virtual DbSet<Mstdepartment> Mstdepartments { get; set; }
        public virtual DbSet<Mstdivision> Mstdivisions { get; set; }
        public virtual DbSet<MstemailTemplate> MstemailTemplates { get; set; }
        public virtual DbSet<Mstemployee> Mstemployees { get; set; }
        public virtual DbSet<Mstio> Mstios { get; set; }
        public virtual DbSet<MstmasterDatum> MstmasterData { get; set; }
        public virtual DbSet<Mstpermission> Mstpermissions { get; set; }
        public virtual DbSet<Mstposition> Mstpositions { get; set; }
        public virtual DbSet<MstpositionLevel> MstpositionLevels { get; set; }
        public virtual DbSet<Mstproject> Mstprojects { get; set; }
        public virtual DbSet<Mstprovince> Mstprovinces { get; set; }
        public virtual DbSet<MstreleasedDocumentTemplate> MstreleasedDocumentTemplates { get; set; }
        public virtual DbSet<MstreportTemplate> MstreportTemplates { get; set; }
        public virtual DbSet<Mstrole> Mstroles { get; set; }
        public virtual DbSet<MstrolePermission> MstrolePermissions { get; set; }
        public virtual DbSet<MsttemLineApprove> MsttemLineApproves { get; set; }
        public virtual DbSet<MsttemSpecificApprover> MsttemSpecificApprovers { get; set; }
        public virtual DbSet<Msttemplate> Msttemplates { get; set; }
        public virtual DbSet<MsttemplateLogic> MsttemplateLogics { get; set; }
        public virtual DbSet<MstuserPermission> MstuserPermissions { get; set; }
        public virtual DbSet<TrnactionHistory> TrnactionHistories { get; set; }
        public virtual DbSet<TrnattachFile> TrnattachFiles { get; set; }
        public virtual DbSet<TrncontrolRunning> TrncontrolRunnings { get; set; }
        public virtual DbSet<Trndelegate> Trndelegates { get; set; }
        public virtual DbSet<TrndelegateDetail> TrndelegateDetails { get; set; }
        public virtual DbSet<TrnedocumentQueue> TrnedocumentQueues { get; set; }
        public virtual DbSet<TrnlineApprove> TrnlineApproves { get; set; }
        public virtual DbSet<Trnmemo> Trnmemos { get; set; }
        public virtual DbSet<TrnreferenceDoc> TrnreferenceDocs { get; set; }
        public virtual DbSet<TrnreleasedDocument> TrnreleasedDocuments { get; set; }
        public virtual DbSet<TrnusageLog> TrnusageLogs { get; set; }
        public virtual DbSet<TrnuserParticipate> TrnuserParticipates { get; set; }
        public virtual DbSet<TrnuserTransaction> TrnuserTransactions { get; set; }
        public virtual DbSet<VTrnparticipateList> VTrnparticipateLists { get; set; }
        public virtual DbSet<ViewApprovalMatrix> ViewApprovalMatrices { get; set; }
        public virtual DbSet<ViewDelegate> ViewDelegates { get; set; }
        public virtual DbSet<ViewEmployee> ViewEmployees { get; set; }
        public virtual DbSet<ViewMasterApproveType> ViewMasterApproveTypes { get; set; }
        public virtual DbSet<ViewPosition> ViewPositions { get; set; }
        public virtual DbSet<ViewReleasedDocument> ViewReleasedDocuments { get; set; }
        public virtual DbSet<ViewReport> ViewReports { get; set; }
        public virtual DbSet<ViewRole> ViewRoles { get; set; }
        public virtual DbSet<ViewRolePermission> ViewRolePermissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Page).HasMaxLength(100);

                entity.Property(e => e.Platform).HasMaxLength(50);

                entity.Property(e => e.PostedBy).HasMaxLength(100);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Site).HasMaxLength(100);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mstaccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTAccount");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountId).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountName).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.LogoPic).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mslicence)
                    .HasMaxLength(100)
                    .HasColumnName("MSLicence");

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeColor).HasMaxLength(10);
            });

            modelBuilder.Entity<MstapprovalMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTApprovalMatrix");

                entity.Property(e => e.ApproveMatrixId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MstapprovalMatrixItem>(entity =>
            {
                entity.HasKey(e => e.ApproveMatrixItemId);

                entity.ToTable("MSTApprovalMatrixItem");

                entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MstauthorizedMenu>(entity =>
            {
                entity.HasKey(e => e.AuMenuId)
                    .HasName("PK_dbo.MSTAuthorizedMenu");

                entity.ToTable("MSTAuthorizedMenu");

                entity.Property(e => e.AuMenuId).HasColumnName("AuMenuID");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupMenu).HasMaxLength(100);

                entity.Property(e => e.ItemMenu).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Process).HasMaxLength(3);

                entity.Property(e => e.RolesId)
                    .HasMaxLength(1000)
                    .HasColumnName("RolesID");

                entity.Property(e => e.SubMenu).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<Mstchecklist>(entity =>
            {
                entity.ToTable("MSTChecklist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Org).HasMaxLength(50);

                entity.Property(e => e.Standards).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Mstcompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__MSTCompa__2D971CAC767A0F1A");

                entity.ToTable("MSTCompany");

                entity.Property(e => e.Bucode)
                    .HasMaxLength(50)
                    .HasColumnName("BUCode");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.Tel).HasMaxLength(100);

                entity.Property(e => e.UrlWeb).HasMaxLength(500);
            });

            modelBuilder.Entity<Mstdepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__MSTDepar__B2079BEDE01B75A9");

                entity.ToTable("MSTDepartment");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<Mstdivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK__MSTDivis__20EFC6A8638EE3E9");

                entity.ToTable("MSTDivision");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionCode).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MstemailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId);

                entity.ToTable("MSTEmailTemplate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailBody).IsUnicode(false);

                entity.Property(e => e.EmailCc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("EmailCC");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FormState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mstemployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__MSTEmplo__7AD04F1108B3D923");

                entity.ToTable("MSTEmployee");

                entity.Property(e => e.Adtitle)
                    .HasMaxLength(500)
                    .HasColumnName("ADTitle");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpLevel).HasMaxLength(50);

                entity.Property(e => e.EmplRcd)
                    .HasMaxLength(500)
                    .HasColumnName("EMPL_RCD");

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.ReportToEmpCode).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Mstio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTIO");

                entity.Property(e => e.CostCenter).HasMaxLength(50);

                entity.Property(e => e.Io)
                    .HasMaxLength(50)
                    .HasColumnName("IO");
            });

            modelBuilder.Entity<MstmasterDatum>(entity =>
            {
                entity.HasKey(e => e.MasterId);

                entity.ToTable("MSTMasterData");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MasterType).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mstpermission>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__MSTPermi__C99ED2305562B93D");

                entity.ToTable("MSTPermission");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuDescription).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<Mstposition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PK__MSTPosit__60BB9A795FC1AE90");

                entity.ToTable("MSTPosition");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MstpositionLevel>(entity =>
            {
                entity.HasKey(e => e.PositionLevelId)
                    .HasName("PK__MSTPosit__5622C997D46D3B94");

                entity.ToTable("MSTPositionLevel");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionLevel).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<Mstproject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__MSTProje__761ABEF0229C0ACB");

                entity.ToTable("MSTProject");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(500);
            });

            modelBuilder.Entity<Mstprovince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTProvince");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Districtthai).HasMaxLength(50);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Provincethai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TambonId).HasColumnName("TambonID");

                entity.Property(e => e.Tambonthai).HasMaxLength(50);
            });

            modelBuilder.Entity<MstreleasedDocumentTemplate>(entity =>
            {
                entity.HasKey(e => e.ReportTemplateId);

                entity.ToTable("MSTReleasedDocumentTemplate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportName).HasMaxLength(500);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TemplateId).HasMaxLength(100);
            });

            modelBuilder.Entity<MstreportTemplate>(entity =>
            {
                entity.HasKey(e => e.ReportTemplateId)
                    .HasName("PK__MSTRepor__C7EA280656C828D8");

                entity.ToTable("MSTReportTemplate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportName).HasMaxLength(500);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TemplateId).HasMaxLength(100);
            });

            modelBuilder.Entity<Mstrole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__MSTRole__8AFACE1AF107DAA0");

                entity.ToTable("MSTRole");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.RoleDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<MstrolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.MenuId, e.AccountId });

                entity.ToTable("MSTRolePermission");
            });

            modelBuilder.Entity<MsttemLineApprove>(entity =>
            {
                entity.HasKey(e => e.TemLineId)
                    .HasName("PK__TRNTemLi__982EA6C15523E293");

                entity.ToTable("MSTTemLineApprove");

                entity.Property(e => e.Conditions).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MsttemSpecificApprover>(entity =>
            {
                entity.HasKey(e => e.TemSpecificId)
                    .HasName("PK__MSTTemSp__73D3754C6B879388");

                entity.ToTable("MSTTemSpecificApprover");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Msttemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTTemplate");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CcId).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.IsFormControl).HasColumnName("isFormControl");

                entity.Property(e => e.IsPdfshowInfo).HasColumnName("isPDFShowInfo");

                entity.Property(e => e.IsPublic).HasColumnName("isPublic");

                entity.Property(e => e.IsRequesterEditApproval).HasColumnName("isRequesterEditApproval");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateId).ValueGeneratedOnAdd();

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.ToId).HasMaxLength(500);
            });

            modelBuilder.Entity<MsttemplateLogic>(entity =>
            {
                entity.HasKey(e => e.Logicid)
                    .HasName("PK__MSTTempl__7B235661149B9A56");

                entity.ToTable("MSTTemplateLogic");

                entity.Property(e => e.Logicid)
                    .HasColumnName("logicid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Jsonvalue)
                    .IsUnicode(false)
                    .HasColumnName("jsonvalue");

                entity.Property(e => e.Logictype)
                    .HasMaxLength(20)
                    .HasColumnName("logictype");
            });

            modelBuilder.Entity<MstuserPermission>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RoleId });

                entity.ToTable("MSTUserPermission");
            });

            modelBuilder.Entity<TrnactionHistory>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK__TRNActio__FFE3F4D97C5024D2");

                entity.ToTable("TRNActionHistory");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionProcess).HasMaxLength(100);

                entity.Property(e => e.ActionStatus).HasMaxLength(100);

                entity.Property(e => e.ActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorName).HasMaxLength(500);

                entity.Property(e => e.ActorNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DelegateActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.DelegateActorNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorNameTh).HasMaxLength(500);

                entity.Property(e => e.DelegateActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.HadvancveForm).HasColumnName("HAdvancveForm");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(500)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.NextApproverId).HasColumnName("NextApproverID");

                entity.Property(e => e.NextApproverName).HasMaxLength(500);

                entity.Property(e => e.Platform).HasMaxLength(100);

                entity.Property(e => e.SignPicPath).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrnattachFile>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("PK__TRNAttac__F517C3F5F00FFEA5");

                entity.ToTable("TRNAttachFile");

                entity.Property(e => e.ActorName).HasMaxLength(500);

                entity.Property(e => e.AttachFile).HasMaxLength(500);

                entity.Property(e => e.AttachedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.FilePath).HasMaxLength(500);

                entity.Property(e => e.IsMergePdf).HasColumnName("IsMergePDF");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrncontrolRunning>(entity =>
            {
                entity.HasKey(e => e.ControlRunningOrder);

                entity.ToTable("TRNControlRunning");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RunningNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<Trndelegate>(entity =>
            {
                entity.HasKey(e => e.DelegateId)
                    .HasName("PK__TRNDeleg__013A45ABA4295E70");

                entity.ToTable("TRNDelegate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrndelegateDetail>(entity =>
            {
                entity.HasKey(e => e.DelegateDetialId)
                    .HasName("PK__TRNDeleg__00BB1BB2F93CCBBB");

                entity.ToTable("TRNDelegateDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrnedocumentQueue>(entity =>
            {
                entity.HasKey(e => e.QueueId)
                    .HasName("PK__TRNEDocu__8324E715609364C2");

                entity.ToTable("TRNEDocumentQueue");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GenaratedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrnlineApprove>(entity =>
            {
                entity.HasKey(e => e.LineApproveId)
                    .HasName("PK__TRNLineA__401DC2E7CC5EB03F");

                entity.ToTable("TRNLineApprove");

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("PositionEN");

                entity.Property(e => e.PositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("PositionTH");

                entity.Property(e => e.SignatureEn).HasMaxLength(500);

                entity.Property(e => e.SignatureTh).HasMaxLength(500);
            });

            modelBuilder.Entity<Trnmemo>(entity =>
            {
                entity.HasKey(e => e.MemoId)
                    .HasName("PK__TRNMemo__8D6CC126A41C6C93");

                entity.ToTable("TRNMemo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("CDepartmentEn");

                entity.Property(e => e.CdepartmentId).HasColumnName("CDepartmentId");

                entity.Property(e => e.CdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("CDepartmentTh");

                entity.Property(e => e.CdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("CDivisionEn");

                entity.Property(e => e.CdivisionId).HasColumnName("CDivisionId");

                entity.Property(e => e.CdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("CDivisionTh");

                entity.Property(e => e.CheckEmpId).HasColumnName("CheckEmpID");

                entity.Property(e => e.CnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("CNameEn");

                entity.Property(e => e.CnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("CNameTh");

                entity.Property(e => e.CompanyName).HasMaxLength(400);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("CPositionEn");

                entity.Property(e => e.CpositionId).HasColumnName("CPositionId");

                entity.Property(e => e.CpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("CPositionTh");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.LastActionBy).HasMaxLength(500);

                entity.Property(e => e.LastStatusName).HasMaxLength(500);

                entity.Property(e => e.MadvancveForm).HasColumnName("MAdvancveForm");

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtextForm).HasColumnName("MTextForm");

                entity.Property(e => e.PersonWaiting).HasMaxLength(500);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(400);

                entity.Property(e => e.RdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("RDepartmentEn");

                entity.Property(e => e.RdepartmentId).HasColumnName("RDepartmentId");

                entity.Property(e => e.RdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("RDepartmentTh");

                entity.Property(e => e.RdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("RDivisionEn");

                entity.Property(e => e.RdivisionId).HasColumnName("RDivisionId");

                entity.Property(e => e.RdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("RDivisionTh");

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("RNameEn");

                entity.Property(e => e.RnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("RNameTh");

                entity.Property(e => e.RpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("RPositionEn");

                entity.Property(e => e.RpositionId).HasColumnName("RPositionId");

                entity.Property(e => e.RpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("RPositionTh");

                entity.Property(e => e.SlacompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLACompletedDate");

                entity.Property(e => e.SlastartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLAStartDate");

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.TadvanceForm).HasColumnName("TAdvanceForm");

                entity.Property(e => e.TemplateApproveId).HasMaxLength(10);

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.TemplateType).HasMaxLength(100);

                entity.Property(e => e.TtextForm).HasColumnName("TTextForm");
            });

            modelBuilder.Entity<TrnreferenceDoc>(entity =>
            {
                entity.HasKey(e => e.RefDocId);

                entity.ToTable("TRNReferenceDoc");

                entity.Property(e => e.RefDocId).HasColumnName("RefDocID");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.MemoId).HasColumnName("MemoID");

                entity.Property(e => e.MemoRefDocId).HasColumnName("MemoRefDocID");

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ShowColumn).HasMaxLength(50);

                entity.Property(e => e.TemplateName).HasMaxLength(500);
            });

            modelBuilder.Entity<TrnreleasedDocument>(entity =>
            {
                entity.HasKey(e => e.ReleasedDocumentId);

                entity.ToTable("TRNReleasedDocuments");

                entity.Property(e => e.ReleasedDocumentId).ValueGeneratedNever();

                entity.Property(e => e.Darnumber).HasColumnName("DARNumber");

                entity.Property(e => e.ReleasedDocumentStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<TrnusageLog>(entity =>
            {
                entity.HasKey(e => e.UsageLogId);

                entity.ToTable("TRNUsageLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionProcess).HasMaxLength(100);

                entity.Property(e => e.ActionStatus).HasMaxLength(100);

                entity.Property(e => e.ActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(500)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Note01).HasColumnType("ntext");

                entity.Property(e => e.Note02).HasColumnType("ntext");

                entity.Property(e => e.Note03).HasColumnType("ntext");

                entity.Property(e => e.Note04).HasColumnType("ntext");

                entity.Property(e => e.Note05).HasColumnType("ntext");

                entity.Property(e => e.Platform).HasMaxLength(100);
            });

            modelBuilder.Entity<TrnuserParticipate>(entity =>
            {
                entity.HasKey(e => e.Upid);

                entity.ToTable("TRNUserParticipate");

                entity.Property(e => e.Upid).HasColumnName("UPID");

                entity.Property(e => e.ActionName).HasMaxLength(100);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.UserParticipateName).HasMaxLength(500);
            });

            modelBuilder.Entity<TrnuserTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__TRNUserT__55433A6B6FC6506B");

                entity.ToTable("TRNUserTransaction");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Channel).HasMaxLength(10);

                entity.Property(e => e.DeviceToken).HasMaxLength(256);
            });

            modelBuilder.Entity<VTrnparticipateList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TRNParticipateList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemoId).HasColumnName("MemoID");
            });

            modelBuilder.Entity<ViewApprovalMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewApprovalMatrix");

                entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewDelegate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDelegate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.Template)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewEmployee");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountName).HasMaxLength(250);

                entity.Property(e => e.Adtitle)
                    .HasMaxLength(500)
                    .HasColumnName("ADTitle");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultLang).HasMaxLength(2);

                entity.Property(e => e.DepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.DepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.DivisionNameEn).HasMaxLength(500);

                entity.Property(e => e.DivisionNameTh).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionNameEn).HasMaxLength(500);

                entity.Property(e => e.PositionNameTh).HasMaxLength(500);

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.ReportToEmpCode).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewMasterApproveType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMasterApproveType");
            });

            modelBuilder.Entity<ViewPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPosition");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionLevelNameEn).HasMaxLength(500);

                entity.Property(e => e.PositionLevelNameTh).HasMaxLength(500);

                entity.Property(e => e.PosotionLevel).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<ViewReleasedDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewReleasedDocuments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("CDepartmentEn");

                entity.Property(e => e.CdepartmentId).HasColumnName("CDepartmentId");

                entity.Property(e => e.CdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("CDepartmentTh");

                entity.Property(e => e.CdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("CDivisionEn");

                entity.Property(e => e.CdivisionId).HasColumnName("CDivisionId");

                entity.Property(e => e.CdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("CDivisionTh");

                entity.Property(e => e.CheckEmpId).HasColumnName("CheckEmpID");

                entity.Property(e => e.CnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("CNameEn");

                entity.Property(e => e.CnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("CNameTh");

                entity.Property(e => e.CompanyName).HasMaxLength(400);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("CPositionEn");

                entity.Property(e => e.CpositionId).HasColumnName("CPositionId");

                entity.Property(e => e.CpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("CPositionTh");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Darnumber).HasColumnName("DARNumber");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.LastActionBy).HasMaxLength(500);

                entity.Property(e => e.LastStatusName).HasMaxLength(500);

                entity.Property(e => e.MadvancveForm).HasColumnName("MAdvancveForm");

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MtextForm).HasColumnName("MTextForm");

                entity.Property(e => e.PersonWaiting).HasMaxLength(500);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(400);

                entity.Property(e => e.RdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("RDepartmentEn");

                entity.Property(e => e.RdepartmentId).HasColumnName("RDepartmentId");

                entity.Property(e => e.RdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("RDepartmentTh");

                entity.Property(e => e.RdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("RDivisionEn");

                entity.Property(e => e.RdivisionId).HasColumnName("RDivisionId");

                entity.Property(e => e.RdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("RDivisionTh");

                entity.Property(e => e.ReleasedDocumentStatus).HasMaxLength(50);

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("RNameEn");

                entity.Property(e => e.RnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("RNameTh");

                entity.Property(e => e.RpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("RPositionEn");

                entity.Property(e => e.RpositionId).HasColumnName("RPositionId");

                entity.Property(e => e.RpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("RPositionTh");

                entity.Property(e => e.SlacompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLACompletedDate");

                entity.Property(e => e.SlastartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLAStartDate");

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.TadvanceForm).HasColumnName("TAdvanceForm");

                entity.Property(e => e.TemplateApproveId).HasMaxLength(10);

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.TemplateType).HasMaxLength(100);

                entity.Property(e => e.TtextForm).HasColumnName("TTextForm");
            });

            modelBuilder.Entity<ViewReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewReport");

                entity.Property(e => e.ActionHistoryAccountId).HasColumnName("ActionHistory_AccountId");

                entity.Property(e => e.ActionHistoryActionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ActionHistory_ActionDate");

                entity.Property(e => e.ActionHistoryActionId).HasColumnName("ActionHistory_ActionId");

                entity.Property(e => e.ActionHistoryActionProcess)
                    .HasMaxLength(100)
                    .HasColumnName("ActionHistory_ActionProcess");

                entity.Property(e => e.ActionHistoryActionStatus)
                    .HasMaxLength(100)
                    .HasColumnName("ActionHistory_ActionStatus");

                entity.Property(e => e.ActionHistoryActorId).HasColumnName("ActionHistory_ActorId");

                entity.Property(e => e.ActionHistoryActorName)
                    .HasMaxLength(500)
                    .HasColumnName("ActionHistory_ActorName");

                entity.Property(e => e.ActionHistoryComment)
                    .HasColumnType("ntext")
                    .HasColumnName("ActionHistory_Comment");

                entity.Property(e => e.ActionHistoryCreatedBy)
                    .HasMaxLength(500)
                    .HasColumnName("ActionHistory_CreatedBy");

                entity.Property(e => e.ActionHistoryCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ActionHistory_CreatedDate");

                entity.Property(e => e.ActionHistoryIsActive).HasColumnName("ActionHistory_IsActive");

                entity.Property(e => e.ActionHistoryMemoId).HasColumnName("ActionHistory_MemoId");

                entity.Property(e => e.ActionHistoryNextApproverId).HasColumnName("ActionHistory_NextApproverID");

                entity.Property(e => e.ActionHistoryNextApproverName).HasMaxLength(500);

                entity.Property(e => e.ActionHistorySignPicPath)
                    .HasMaxLength(500)
                    .HasColumnName("ActionHistory_SignPicPath");

                entity.Property(e => e.ActionHistorySignatureId).HasColumnName("ActionHistory_SignatureId");

                entity.Property(e => e.ActionHistoryStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ActionHistory_StartDate");

                entity.Property(e => e.AttachFileAccountId).HasColumnName("AttachFile_AccountId");

                entity.Property(e => e.AttachFileActorId).HasColumnName("AttachFile_ActorId");

                entity.Property(e => e.AttachFileActorName)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_ActorName");

                entity.Property(e => e.AttachFileAttachFile)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_AttachFile");

                entity.Property(e => e.AttachFileAttachId).HasColumnName("AttachFile_AttachId");

                entity.Property(e => e.AttachFileAttachedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AttachFile_AttachedDate");

                entity.Property(e => e.AttachFileCreatedBy)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_CreatedBy");

                entity.Property(e => e.AttachFileCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AttachFile_CreatedDate");

                entity.Property(e => e.AttachFileDelegateId).HasColumnName("AttachFile_DelegateId");

                entity.Property(e => e.AttachFileFileName)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_FileName");

                entity.Property(e => e.AttachFileFilePath)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_FilePath");

                entity.Property(e => e.AttachFileMemoId).HasColumnName("AttachFile_MemoId");

                entity.Property(e => e.AttachFileModifiedBy)
                    .HasMaxLength(500)
                    .HasColumnName("AttachFile_ModifiedBy");

                entity.Property(e => e.AttachFileModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("AttachFile_ModifiedDate");

                entity.Property(e => e.LineApproveAccountId).HasColumnName("LineApprove_AccountId");

                entity.Property(e => e.LineApproveEmployeeCode)
                    .HasMaxLength(10)
                    .HasColumnName("LineApprove_EmployeeCode");

                entity.Property(e => e.LineApproveEmployeeId).HasColumnName("LineApprove_EmployeeId");

                entity.Property(e => e.LineApproveIsActive).HasColumnName("LineApprove_IsActive");

                entity.Property(e => e.LineApproveLineApproveId).HasColumnName("LineApprove_LineApproveId");

                entity.Property(e => e.LineApproveMemoId).HasColumnName("LineApprove_MemoId");

                entity.Property(e => e.LineApproveNameEn)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_NameEn");

                entity.Property(e => e.LineApproveNameTh)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_NameTh");

                entity.Property(e => e.LineApprovePositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_PositionEN");

                entity.Property(e => e.LineApprovePositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_PositionTH");

                entity.Property(e => e.LineApproveSeq).HasColumnName("LineApprove_Seq");

                entity.Property(e => e.LineApproveSignatureEn)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_SignatureEn");

                entity.Property(e => e.LineApproveSignatureId).HasColumnName("LineApprove_SignatureId");

                entity.Property(e => e.LineApproveSignatureTh)
                    .HasMaxLength(500)
                    .HasColumnName("LineApprove_SignatureTh");

                entity.Property(e => e.MemoAccountId).HasColumnName("Memo_AccountId");

                entity.Property(e => e.MemoAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Memo_Amount");

                entity.Property(e => e.MemoApproverCanEdit).HasColumnName("Memo_ApproverCanEdit");

                entity.Property(e => e.MemoAutoApprove).HasColumnName("Memo_AutoApprove");

                entity.Property(e => e.MemoAutoApproveWhen)
                    .HasMaxLength(2)
                    .HasColumnName("Memo_AutoApproveWhen");

                entity.Property(e => e.MemoCcPerson).HasColumnName("Memo_CcPerson");

                entity.Property(e => e.MemoCdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CDepartmentEn");

                entity.Property(e => e.MemoCdepartmentId).HasColumnName("Memo_CDepartmentId");

                entity.Property(e => e.MemoCdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CDepartmentTh");

                entity.Property(e => e.MemoCdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CDivisionEn");

                entity.Property(e => e.MemoCdivisionId).HasColumnName("Memo_CDivisionId");

                entity.Property(e => e.MemoCdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CDivisionTh");

                entity.Property(e => e.MemoCnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CNameEn");

                entity.Property(e => e.MemoCnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CNameTh");

                entity.Property(e => e.MemoCompanyName)
                    .HasMaxLength(400)
                    .HasColumnName("Memo_CompanyName");

                entity.Property(e => e.MemoCpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CPositionEn");

                entity.Property(e => e.MemoCpositionId).HasColumnName("Memo_CPositionId");

                entity.Property(e => e.MemoCpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CPositionTh");

                entity.Property(e => e.MemoCreatedBy)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_CreatedBy");

                entity.Property(e => e.MemoCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Memo_CreatedDate");

                entity.Property(e => e.MemoCreatorId).HasColumnName("Memo_CreatorId");

                entity.Property(e => e.MemoCurrentApprovalLevel).HasColumnName("Memo_CurrentApprovalLevel");

                entity.Property(e => e.MemoDepartmentId).HasColumnName("Memo_DepartmentId");

                entity.Property(e => e.MemoDocumentCode)
                    .HasMaxLength(50)
                    .HasColumnName("Memo_DocumentCode");

                entity.Property(e => e.MemoDocumentNo)
                    .HasMaxLength(50)
                    .HasColumnName("Memo_DocumentNo");

                entity.Property(e => e.MemoIsPublic).HasColumnName("Memo_IsPublic");

                entity.Property(e => e.MemoLastActionBy)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_LastActionBy");

                entity.Property(e => e.MemoLastStatusId).HasColumnName("Memo_LastStatusId");

                entity.Property(e => e.MemoLastStatusName)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_LastStatusName");

                entity.Property(e => e.MemoMadvancveForm).HasColumnName("Memo_MAdvancveForm");

                entity.Property(e => e.MemoMemoId).HasColumnName("Memo_MemoId");

                entity.Property(e => e.MemoMemoSubject)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_MemoSubject");

                entity.Property(e => e.MemoModifiedBy)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_ModifiedBy");

                entity.Property(e => e.MemoModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Memo_ModifiedDate");

                entity.Property(e => e.MemoMtextForm).HasColumnName("Memo_MTextForm");

                entity.Property(e => e.MemoPersonWaiting)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_PersonWaiting");

                entity.Property(e => e.MemoPersonWaitingId).HasColumnName("Memo_PersonWaitingId");

                entity.Property(e => e.MemoRdepartmentEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RDepartmentEn");

                entity.Property(e => e.MemoRdepartmentId).HasColumnName("Memo_RDepartmentId");

                entity.Property(e => e.MemoRdepartmentTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RDepartmentTh");

                entity.Property(e => e.MemoRdivisionEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RDivisionEn");

                entity.Property(e => e.MemoRdivisionId).HasColumnName("Memo_RDivisionId");

                entity.Property(e => e.MemoRdivisionTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RDivisionTh");

                entity.Property(e => e.MemoReportLang)
                    .HasMaxLength(2)
                    .HasColumnName("Memo_ReportLang");

                entity.Property(e => e.MemoRequestDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Memo_RequestDate");

                entity.Property(e => e.MemoRequesterCode)
                    .HasMaxLength(10)
                    .HasColumnName("Memo_RequesterCode");

                entity.Property(e => e.MemoRequesterId).HasColumnName("Memo_RequesterId");

                entity.Property(e => e.MemoRnameEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RNameEn");

                entity.Property(e => e.MemoRnameTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RNameTh");

                entity.Property(e => e.MemoRpositionEn)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RPositionEn");

                entity.Property(e => e.MemoRpositionId).HasColumnName("Memo_RPositionId");

                entity.Property(e => e.MemoRpositionTh)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_RPositionTh");

                entity.Property(e => e.MemoStatusId).HasColumnName("Memo_StatusId");

                entity.Property(e => e.MemoStatusName)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_StatusName");

                entity.Property(e => e.MemoTadvanceForm).HasColumnName("Memo_TAdvanceForm");

                entity.Property(e => e.MemoTemplateDetail)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_TemplateDetail");

                entity.Property(e => e.MemoTemplateId).HasColumnName("Memo_TemplateId");

                entity.Property(e => e.MemoTemplateName)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_TemplateName");

                entity.Property(e => e.MemoTemplateSubject)
                    .HasMaxLength(500)
                    .HasColumnName("Memo_TemplateSubject");

                entity.Property(e => e.MemoTemplateType)
                    .HasMaxLength(100)
                    .HasColumnName("Memo_TemplateType");

                entity.Property(e => e.MemoToPerson).HasColumnName("Memo_ToPerson");

                entity.Property(e => e.MemoTtextForm).HasColumnName("Memo_TTextForm");
            });

            modelBuilder.Entity<ViewRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewRole");

                entity.Property(e => e.EmpNameEn).HasMaxLength(500);

                entity.Property(e => e.EmpNameTh).HasMaxLength(500);

                entity.Property(e => e.RoleNameEn).HasMaxLength(500);

                entity.Property(e => e.RoleNameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewRolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewRolePermission");

                entity.Property(e => e.MenuDescription).HasMaxLength(1000);

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
