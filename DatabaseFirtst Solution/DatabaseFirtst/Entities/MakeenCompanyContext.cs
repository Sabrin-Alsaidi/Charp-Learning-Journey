﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirtst.Entities
{
    public partial class MakeenCompanyContext : DbContext
    {
        public MakeenCompanyContext()
        {
        }

        public MakeenCompanyContext(DbContextOptions<MakeenCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departmant> Departmants { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-IFPCQQN\\MSSQLS ;Initial Catalog=MakeenCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departmant>(entity =>
            {
                entity.HasKey(e => e.DepId)
                    .HasName("PK__Departma__BB4BD8F80D582E4C");

                entity.ToTable("Departmant");

                entity.Property(e => e.DepId).HasColumnName("dep_id");

                entity.Property(e => e.DepLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dep_location");

                entity.Property(e => e.DepName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dep_name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__1299A8611B8084F2");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.EmpAge).HasColumnName("emp_age");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpSalary).HasColumnName("emp_salary");

                entity.HasOne(d => d.DIdNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DId)
                    .HasConstraintName("FK__Employee__d_id__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
