﻿// <auto-generated />
using System;
using HR.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR.Persistence.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20231204073128_editExpenditure")]
    partial class editExpenditure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HR.Domain.Concrete.AdvancePayment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("AdvanceType")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("ApprovalStatus")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("CurrencyType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("AdvancePayments");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3917),
                            IsActive = true,
                            Name = "Mekanik Tasarım"
                        },
                        new
                        {
                            Id = new Guid("2839f286-c556-4fa7-8fd1-a058365b55e3"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3935),
                            IsActive = true,
                            Name = "İnsan Kaynakları"
                        },
                        new
                        {
                            Id = new Guid("47ffa12f-1b14-4894-be08-0e13a9adaadb"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3937),
                            IsActive = true,
                            Name = "Muhasebe"
                        },
                        new
                        {
                            Id = new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3938),
                            IsActive = true,
                            Name = "Bilişim Teknolojileri"
                        });
                });

            modelBuilder.Entity("HR.Domain.Concrete.Expenditure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte>("ApprovalStatus")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("CurrencyType")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ExchangeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ExpenditureTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PersonnelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExpenditureTypeId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("Expenditures");
                });

            modelBuilder.Entity("HR.Domain.Concrete.ExpenditureType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ExpenditureTypes");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4102),
                            IsActive = true,
                            Name = "Yazılım Mühendisi"
                        },
                        new
                        {
                            Id = new Guid("7136d9fb-50d9-4e6b-8585-e5ae612e396f"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4104),
                            IsActive = true,
                            Name = "FrontEnd Geliştici"
                        },
                        new
                        {
                            Id = new Guid("0ee3ab68-3ff8-49a3-b55d-dfa550f3a4fb"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4106),
                            IsActive = true,
                            Name = "BackEnd Geliştici"
                        },
                        new
                        {
                            Id = new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4108),
                            IsActive = true,
                            Name = "İnşaat Mühendisi"
                        },
                        new
                        {
                            Id = new Guid("9335a9e3-c097-4f51-a907-d6c223f8e473"),
                            CreatedDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4110),
                            IsActive = true,
                            Name = "Endüstri Mühendisi"
                        });
                });

            modelBuilder.Entity("HR.Domain.Concrete.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Days")
                        .HasColumnType("real");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HR.Domain.Concrete.PermissionRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("ApprovalStatus")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Days")
                        .HasColumnType("real");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PermissionTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PermissionTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("PermissionRequests");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Personnel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar");

                    b.Property<float?>("AnnualPermissionDays")
                        .HasColumnType("real");

                    b.Property<DateTime>("BirthDate")
                        .HasMaxLength(15)
                        .HasColumnType("date");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FireDate")
                        .HasMaxLength(15)
                        .HasColumnType("date");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("HireDate")
                        .HasMaxLength(15)
                        .HasColumnType("date");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar");

                    b.Property<string>("PlaceofBirth")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("SecondName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("SecondSurname")
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.ToTable("Personnels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"),
                            Address = "Kadıköy/İstanbul",
                            BirthDate = new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyName = "Google",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"),
                            Email = "betul.demir@bilgeadamboost.com",
                            Gender = (byte)1,
                            HireDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4177),
                            IdentityNumber = "65803196176",
                            IsActive = true,
                            JobId = new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"),
                            Name = "Elif",
                            PhoneNumber = "5226932145",
                            Photo = "image_avatar-female.png",
                            PlaceofBirth = "İstanbul",
                            Salary = 34000,
                            SecondName = "Betül",
                            Surname = "Demir"
                        },
                        new
                        {
                            Id = new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"),
                            Address = "Yenibosna/İstanbul",
                            BirthDate = new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyName = "Microsoft",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"),
                            Email = "muhammet.coskun@bilgeadamboost.com",
                            Gender = (byte)0,
                            HireDate = new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4185),
                            IdentityNumber = "58963214568",
                            IsActive = true,
                            JobId = new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"),
                            Name = "Muhammet",
                            PhoneNumber = "5226932145",
                            Photo = "image_avatar-female.png",
                            PlaceofBirth = "İstanbul",
                            Salary = 34000,
                            Surname = "Coşkun"
                        });
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.Role.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("38627780-5488-4603-bf58-0fc3effb909d"),
                            ConcurrencyStamp = "83e0bf0c-f619-4cce-bd9c-0876035be521",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        });
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HR.Domain.Concrete.AdvancePayment", b =>
                {
                    b.HasOne("HR.Domain.Concrete.Personnel", "Person")
                        .WithMany("AdvancePayments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Expenditure", b =>
                {
                    b.HasOne("HR.Domain.Concrete.ExpenditureType", "ExpenditureType")
                        .WithMany("Expenditures")
                        .HasForeignKey("ExpenditureTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenditureType");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("HR.Domain.Concrete.PermissionRequest", b =>
                {
                    b.HasOne("HR.Domain.Concrete.Permission", "PermissionType")
                        .WithMany("PermissionRequests")
                        .HasForeignKey("PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.Personnel", "Person")
                        .WithMany("PermissonRequests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Personnel", b =>
                {
                    b.HasOne("HR.Domain.Concrete.Department", "Department")
                        .WithMany("People")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.Job", "Job")
                        .WithMany("People")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Role.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Role.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Concrete.Department", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("HR.Domain.Concrete.ExpenditureType", b =>
                {
                    b.Navigation("Expenditures");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Job", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Permission", b =>
                {
                    b.Navigation("PermissionRequests");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Personnel", b =>
                {
                    b.Navigation("AdvancePayments");

                    b.Navigation("PermissonRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
