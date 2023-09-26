using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SyncDataApp.data.Center
{
    public partial class CenterTContext : DbContext
    {
        string connectionString = ConfigurationManager.ConnectionStrings["WolfAproveCenter"].ConnectionString;
        public CenterTContext()
        {
        }

        public CenterTContext(DbContextOptions<CenterTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactLogIn> ContactLogIns { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<MsttemplateLogic> MsttemplateLogics { get; set; }
        public virtual DbSet<Wolfaccount> Wolfaccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_100_CI_AS");

            modelBuilder.Entity<ContactLogIn>(entity =>
            {
                entity.ToTable("ContactLogIn");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GuidVerify)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ContactUS");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Account).HasMaxLength(100);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AdminAccount).HasMaxLength(100);

                entity.Property(e => e.ApiUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.ConnectionString).HasMaxLength(500);

                entity.Property(e => e.ContactCode).HasMaxLength(50);

                entity.Property(e => e.ContactEmail).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(500);

                entity.Property(e => e.Prefix).HasMaxLength(100);

                entity.Property(e => e.RequesDate).HasColumnType("datetime");

                entity.Property(e => e.SharepointSiteAdmin).HasMaxLength(500);

                entity.Property(e => e.SharepointSiteUrl)
                    .HasMaxLength(100)
                    .HasColumnName("SharepointSiteURL");

                entity.Property(e => e.Smtpconfig)
                    .HasMaxLength(1000)
                    .HasColumnName("SMTPConfig");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.TinyUrl)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TinyURL");
            });

            modelBuilder.Entity<MsttemplateLogic>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK__MSTTempl__385EFE68E59A17E9");

                entity.ToTable("MSTTemplateLogic");

                entity.Property(e => e.AutoId).HasColumnName("autoID");

                entity.Property(e => e.Jsonvalue)
                    .IsUnicode(false)
                    .HasColumnName("jsonvalue");

                entity.Property(e => e.Logicid)
                    .HasColumnName("logicid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Logictype)
                    .HasMaxLength(20)
                    .HasColumnName("logictype");
            });

            modelBuilder.Entity<Wolfaccount>(entity =>
            {
                entity.ToTable("WOLFAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GuidVerify).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
