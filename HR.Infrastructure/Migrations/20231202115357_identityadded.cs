using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class identityadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1bf71988-0398-45e3-8ad0-d7f53aa8bc5d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("30e3eda5-ccf2-4ac9-91fc-2cba2f7d8115"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b1cc6787-4ac2-4195-9f81-db09cb35e078"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bbb9495e-a877-48bf-b4e9-2a3263627849"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1ed7058d-3323-4720-89f8-842933e0643e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c1663d0d-9821-415e-b5f3-cc0bec946771"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd1aab46-b4ce-449d-8c27-151f7ef4f566"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e4e7537f-be94-4fc5-892d-8b8027dca82a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f9b0d612-6e20-4755-b726-d5cb619527f8"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SecondName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SecondSurname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Mail = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Photo = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: false),
                    PlaceofBirth = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: false),
                    FireDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: true),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    AnnualTakeAdvanceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AnnualPermissionDays = table.Column<float>(type: "real", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Days = table.Column<float>(type: "real", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancePayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdvanceType = table.Column<byte>(type: "tinyint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyType = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovalStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePayment_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Days = table.Column<float>(type: "real", nullable: false),
                    ApprovalStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionRequest_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRequest_Permission_PermissionTypeId",
                        column: x => x.PermissionTypeId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("14b93bc2-7629-4d9d-abc6-4614d93ca03b"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8746), null, true, "HR", null },
                    { new Guid("19d5e2a3-c627-4827-b664-65210694f854"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8720), null, true, "Mechanical Design", null },
                    { new Guid("cbe82207-3ef2-4a38-831e-64cdcf94abf6"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8749), null, true, "Accounting", null },
                    { new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8751), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("29f64270-2f72-48ea-8753-ca342284aebd"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8903), null, true, "Industrial Engineer", null },
                    { new Guid("451e1d77-8668-49c7-a438-b842f0c1eacb"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8899), null, true, "BackEnd Developer", null },
                    { new Guid("bdf84c5a-e3e4-4cfe-8c9a-3afcdccf072f"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8893), null, true, "FrontEnd Developer", null },
                    { new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8889), null, true, "Software Developer", null },
                    { new Guid("e847c120-1dc9-4bff-844a-55260832ef22"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8901), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Mail", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6d8b46b8-4420-41e8-b857-d44a27914c1b"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "29c5533c-4c5c-4e88-9f16-d2a415f8124c", new Guid("19d5e2a3-c627-4827-b664-65210694f854"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8996), "58963214568", new Guid("e847c120-1dc9-4bff-844a-55260832ef22"), false, null, null, "Muhammet", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, null },
                    { new Guid("c3b877af-050d-4823-87dc-06b54eaabed3"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "cfbf58cf-0b8e-41fb-aa9d-6f9d2ff7c0eb", new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"), null, false, null, (byte)1, new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8982), "65803196176", new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"), false, null, null, "Elif", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePayment_PersonId",
                table: "AdvancePayment",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRequest_PermissionTypeId",
                table: "PermissionRequest",
                column: "PermissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRequest_PersonId",
                table: "PermissionRequest",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancePayment");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PermissionRequest");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("14b93bc2-7629-4d9d-abc6-4614d93ca03b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("19d5e2a3-c627-4827-b664-65210694f854"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cbe82207-3ef2-4a38-831e-64cdcf94abf6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("29f64270-2f72-48ea-8753-ca342284aebd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("451e1d77-8668-49c7-a438-b842f0c1eacb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("bdf84c5a-e3e4-4cfe-8c9a-3afcdccf072f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e847c120-1dc9-4bff-844a-55260832ef22"));

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FireDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: true),
                    HireDate = table.Column<DateTime>(type: "date", maxLength: 15, nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Mail = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Photo = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    PlaceofBirth = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    SecondName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    SecondSurname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1bf71988-0398-45e3-8ad0-d7f53aa8bc5d"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4653), null, true, "Information Technology", null },
                    { new Guid("30e3eda5-ccf2-4ac9-91fc-2cba2f7d8115"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4652), null, true, "Accounting", null },
                    { new Guid("b1cc6787-4ac2-4195-9f81-db09cb35e078"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4650), null, true, "HR", null },
                    { new Guid("bbb9495e-a877-48bf-b4e9-2a3263627849"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4632), null, true, "Mechanical Design", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1ed7058d-3323-4720-89f8-842933e0643e"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4769), null, true, "FrontEnd Developer", null },
                    { new Guid("c1663d0d-9821-415e-b5f3-cc0bec946771"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4774), null, true, "BackEnd Developer", null },
                    { new Guid("dd1aab46-b4ce-449d-8c27-151f7ef4f566"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4767), null, true, "Software Developer", null },
                    { new Guid("e4e7537f-be94-4fc5-892d-8b8027dca82a"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4777), null, true, "Industrial Engineer", null },
                    { new Guid("f9b0d612-6e20-4755-b726-d5cb619527f8"), new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4775), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "HireDate", "IdentityNumber", "IsActive", "JobId", "Mail", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("55a8d686-dea1-4331-8428-3fd8f475412d"), "Yenibosna/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4801), null, new Guid("bbb9495e-a877-48bf-b4e9-2a3263627849"), null, new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4802), "65803196176", true, new Guid("f9b0d612-6e20-4755-b726-d5cb619527f8"), "muhammet.coşkun@bilgeadam.com", "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null },
                    { new Guid("78516afa-1058-4808-8da2-6b79dc0592fb"), "Kadıköy/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4793), null, new Guid("1bf71988-0398-45e3-8ad0-d7f53aa8bc5d"), null, new DateTime(2023, 11, 27, 0, 39, 14, 370, DateTimeKind.Local).AddTicks(4796), "65803196176", true, new Guid("dd1aab46-b4ce-449d-8c27-151f7ef4f566"), "elif.demir@bilgeadam.com", "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_DepartmentId",
                table: "People",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_People_JobId",
                table: "People",
                column: "JobId");
        }
    }
}
