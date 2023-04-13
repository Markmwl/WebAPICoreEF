using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Model;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TEfDemo> TEfDemos { get; set; }

    public virtual DbSet<Xxluser> Xxlusers { get; set; }

    public virtual DbSet<用户表> 用户表s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (Common.Common.IsDevelopment)
        {
            Console.WriteLine("Debug");
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User ID=Mark;Password=123456;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA= (SERVER = DEDICATED)(SERVICE_NAME=ORCL)))");

        }
        else
        {
            Console.WriteLine("Release");
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseOracle("User ID=ZX;Password=123456;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA= (SERVER = DEDICATED)(SERVICE_NAME=ORCL)))");

        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Common.Common.IsDevelopment ?"MARK":"ZX");

        modelBuilder.Entity<TEfDemo>(entity =>
        {
            entity.ToTable("T_EF_DEMO");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Age)
                .HasColumnType("NUMBER")
                .HasColumnName("AGE");
            entity.Property(e => e.Dept)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEPT");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Hobbly)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HOBBLY");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE");
            entity.Property(e => e.Sex)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Text)
                .HasColumnType("CLOB")
                .HasColumnName("TEXT");
            entity.Property(e => e.Time)
                .HasColumnType("DATE")
                .HasColumnName("TIME");
        });

        modelBuilder.Entity<Xxluser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_XXLUSER_ID");

            entity.ToTable("XXLUSER");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Age)
                .HasMaxLength(3)
                .HasColumnName("AGE");
            entity.Property(e => e.Currentdate)
                .HasColumnType("DATE")
                .HasColumnName("CURRENTDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(15)
                .HasColumnName("PHONENUMBER");
            entity.Property(e => e.Sex)
                .HasMaxLength(2)
                .HasColumnName("SEX");
        });

        modelBuilder.Entity<用户表>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ID");

            entity.ToTable("用户表");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.Age)
                .HasMaxLength(3)
                .HasColumnName("AGE");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(15)
                .HasColumnName("PHONENUMBER");
            entity.Property(e => e.Sex)
                .HasMaxLength(2)
                .HasColumnName("SEX");
        });
        modelBuilder.HasSequence("T_CDC_DEMO_SEQ");
        modelBuilder.HasSequence("T_CLEAR_CASHBUSINESS_SEQ");
        modelBuilder.HasSequence("T_RUNLOG_SEQ");
        modelBuilder.HasSequence("XXL_JOB_GROUP_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_INFO_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_LOG_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_LOG_REPORT_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_LOGGLUE_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_REGISTRY_ID").IsCyclic();
        modelBuilder.HasSequence("XXL_JOB_USER_ID").IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
