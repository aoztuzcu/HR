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
    [Migration("20231202131302_seeddataupdated2")]
    partial class seeddataupdated2
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

                    b.Property<DateTime>("ApprovalDate")
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

                    b.ToTable("AdvancePayment");
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
                            Id = new Guid("ba50568a-3794-41f4-bd65-8a9248a2e0dd"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3056),
                            IsActive = true,
                            Name = "Mechanical Design"
                        },
                        new
                        {
                            Id = new Guid("8699c42f-32cb-480e-ad9c-6de13895720c"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3083),
                            IsActive = true,
                            Name = "HR"
                        },
                        new
                        {
                            Id = new Guid("5cf0c63f-eb64-42f0-a202-ff67ef7d81a4"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3091),
                            IsActive = true,
                            Name = "Accounting"
                        },
                        new
                        {
                            Id = new Guid("e0f57c7a-b333-452b-8f64-d818ade5620f"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3095),
                            IsActive = true,
                            Name = "Information Technology"
                        });
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
                            Id = new Guid("f62cc891-91b3-4430-9c39-b45f50b3e5d0"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3395),
                            IsActive = true,
                            Name = "Software Developer"
                        },
                        new
                        {
                            Id = new Guid("9435d648-4fd7-42a7-a7a2-8ae545f62a3d"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3400),
                            IsActive = true,
                            Name = "FrontEnd Developer"
                        },
                        new
                        {
                            Id = new Guid("66c12bd3-c43b-4bd3-bf03-c5c7b2162b71"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3409),
                            IsActive = true,
                            Name = "BackEnd Developer"
                        },
                        new
                        {
                            Id = new Guid("4b1e8446-8459-4e35-8bd8-af7ff0e2c5ee"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3411),
                            IsActive = true,
                            Name = "Civil Engineer"
                        },
                        new
                        {
                            Id = new Guid("a5221e58-7f87-471c-ac60-2f36df08b23e"),
                            CreatedDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3415),
                            IsActive = true,
                            Name = "Industrial Engineer"
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

                    b.ToTable("Permission");
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

                    b.ToTable("PermissionRequest");
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar");

                    b.Property<float?>("AnnualPermissionDays")
                        .HasColumnType("real");

                    b.Property<decimal?>("AnnualTakeAdvanceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BirthDate")
                        .HasMaxLength(15)
                        .HasColumnType("date");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8bf129c4-9162-412d-a7a7-b7021aa43ad2"),
                            AccessFailedCount = 0,
                            Address = "Kadıköy/İstanbul",
                            BirthDate = new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyName = "Google",
                            ConcurrencyStamp = "fd524119-839a-4568-a7c4-a85d9c6b0291",
                            DepartmentId = new Guid("e0f57c7a-b333-452b-8f64-d818ade5620f"),
                            Email = "elifbetul.demir@bilgeadamboost.com",
                            EmailConfirmed = true,
                            Gender = (byte)1,
                            HireDate = new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3591),
                            IdentityNumber = "65803196176",
                            JobId = new Guid("f62cc891-91b3-4430-9c39-b45f50b3e5d0"),
                            LockoutEnabled = false,
                            Name = "Elif",
                            NormalizedEmail = "ELIFBETUL.DEMIR@BILGEADAMBOOST.COM",
                            NormalizedUserName = "BETULDEMIR",
                            PasswordHash = "AQAAAAEAACcQAAAAEBxoXj6J5dzutsIExlEpCfQk2KLPGrEz7tATMEP44fCffgysTWH7C9Re5lMq7pwGGQ==",
                            PhoneNumber = "5226932145",
                            PhoneNumberConfirmed = true,
                            Photo = "image_avatar-female.png",
                            PlaceofBirth = "İstanbul",
                            Salary = 34000,
                            SecondName = "Betül",
                            SecurityStamp = "D2C7BG653KANTFOB6NNHCOSN2R7GM27A",
                            Surname = "Demir",
                            TwoFactorEnabled = false,
                            UserName = "betuldemir"
                        },
                        new
                        {
                            Id = new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7"),
                            AccessFailedCount = 0,
                            Address = "Yenibosna/İstanbul",
                            BirthDate = new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyName = "Microsoft",
                            ConcurrencyStamp = "d1e8b12d-2d25-4244-a23f-cb00b22189ef",
                            DepartmentId = new Guid("ba50568a-3794-41f4-bd65-8a9248a2e0dd"),
                            Email = "muhammet.coskun@bilgeadamboost.com",
                            EmailConfirmed = true,
                            Gender = (byte)0,
                            HireDate = new DateTime(2023, 12, 2, 16, 13, 1, 788, DateTimeKind.Local).AddTicks(6315),
                            IdentityNumber = "58963214568",
                            JobId = new Guid("4b1e8446-8459-4e35-8bd8-af7ff0e2c5ee"),
                            LockoutEnabled = false,
                            Name = "Muhammet",
                            NormalizedEmail = "MUHAMMET.COSKUN@BILGEADAMBOOST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKON50WddSvkqYkCHhba7qNgWQiCa+0zLzFl0xnrdKGSBFK5flhM2uWtWPyG4b93pw==",
                            PhoneNumber = "5226932145",
                            PhoneNumberConfirmed = true,
                            Photo = "image_avatar-female.png",
                            PlaceofBirth = "İstanbul",
                            Salary = 34000,
                            SecurityStamp = "D2C7BG653KANTFOB6NNHCOSN2R7GM27B",
                            Surname = "Coşkun",
                            TwoFactorEnabled = false,
                            UserName = "muhammetcoskun"
                        });
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.Role.PersonRole", b =>
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
                            Id = new Guid("26ba8d47-2604-4681-9de1-056231262487"),
                            ConcurrencyStamp = "46005c23-dc45-4ce9-8ecd-c66d7a51ec97",
                            Name = "Personnel"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7"),
                            RoleId = new Guid("26ba8d47-2604-4681-9de1-056231262487")
                        });
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
                    b.HasOne("HR.Domain.Concrete.User.Person", "Person")
                        .WithMany("AdvancePayments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HR.Domain.Concrete.PermissionRequest", b =>
                {
                    b.HasOne("HR.Domain.Concrete.Permission", "PermissionType")
                        .WithMany("PermissionRequests")
                        .HasForeignKey("PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.User.Person", "Person")
                        .WithMany("PermissonRequests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.Person", b =>
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
                    b.HasOne("HR.Domain.Concrete.User.Role.PersonRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Role.PersonRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.Domain.Concrete.User.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("HR.Domain.Concrete.User.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HR.Domain.Concrete.Department", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Job", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("HR.Domain.Concrete.Permission", b =>
                {
                    b.Navigation("PermissionRequests");
                });

            modelBuilder.Entity("HR.Domain.Concrete.User.Person", b =>
                {
                    b.Navigation("AdvancePayments");

                    b.Navigation("PermissonRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
