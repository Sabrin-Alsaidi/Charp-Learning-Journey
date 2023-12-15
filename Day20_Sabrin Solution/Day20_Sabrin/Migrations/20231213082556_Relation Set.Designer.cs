﻿// <auto-generated />
using System;
using Day20_Sabrin.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Day20_Sabrin.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231213082556_Relation Set")]
    partial class RelationSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Day20_Sabrin.Models.Department", b =>
                {
                    b.Property<int>("Dep_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dep_Id"), 1L, 1);

                    b.Property<int>("Dep_Floor")
                        .HasColumnType("int");

                    b.Property<string>("Dep_Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Dep_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Day20_Sabrin.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_Id"), 1L, 1);

                    b.Property<int?>("DepId")
                        .HasColumnType("int");

                    b.Property<int>("Employee_Age")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Employee_Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Employee_Id");

                    b.HasIndex("DepId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Day20_Sabrin.Models.Projects", b =>
                {
                    b.Property<int>("Projects_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Projects_Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Projects_Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.Property<int>("EmplyeeProjectEmployee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Projects_Id")
                        .HasColumnType("int");

                    b.HasKey("EmplyeeProjectEmployee_Id", "Projects_Id");

                    b.HasIndex("Projects_Id");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("Day20_Sabrin.Models.Employee", b =>
                {
                    b.HasOne("Day20_Sabrin.Models.Department", "Departments")
                        .WithMany("EmployeeDepartment")
                        .HasForeignKey("DepId");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.HasOne("Day20_Sabrin.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmplyeeProjectEmployee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Day20_Sabrin.Models.Projects", null)
                        .WithMany()
                        .HasForeignKey("Projects_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Day20_Sabrin.Models.Department", b =>
                {
                    b.Navigation("EmployeeDepartment");
                });
#pragma warning restore 612, 618
        }
    }
}