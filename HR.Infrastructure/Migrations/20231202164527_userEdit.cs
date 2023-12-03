using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class userEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayment_AspNetUsers_PersonId",
                table: "AdvancePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequest_AspNetUsers_PersonId",
                table: "PermissionRequest");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b011d880-d9f4-4b5f-95ec-45b945857427"), new Guid("8b0547c9-1d75-4b0f-b1ac-c927309a93d0") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("25e208aa-3e8b-425e-93a7-d50287fb1b38"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("45055d9f-3b0c-4309-b8bd-a59f3f49832f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b526f602-b268-4057-a11e-d92a8ef55029"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("089fd991-c500-4d56-a06b-90c83a9d35d1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c3f19eb-76ad-4915-a607-9c51b406aafe"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9b72fa1c-d4b0-4d52-820a-f4421197c314"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b011d880-d9f4-4b5f-95ec-45b945857427"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b0547c9-1d75-4b0f-b1ac-c927309a93d0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d8632eb2-65b5-4d56-8efc-400fa80a66da"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7e35cefc-a7af-42e5-9c07-44c36860d424"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e94abdc9-27aa-4ee8-9315-ff41c134f595"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("eb15adb6-db80-4f0c-a317-ab5512119234"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnnualPermissionDays",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AnnualTakeAdvanceAmount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FireDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PlaceofBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SecondSurname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalDate",
                table: "AdvancePayment",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SecondName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    SecondSurname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
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
                    AnnualPermissionDays = table.Column<float>(type: "real", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnels_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnels_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("25549a56-8a84-4ccd-85f0-c647f3f83dae"), "23e3ecf8-ebd3-4e1f-8ba2-a4334f871b8f", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1512eef0-1c66-440b-9f0c-5d01cc4fd4d8"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3732), null, true, "HR", null },
                    { new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3718), null, true, "Mechanical Design", null },
                    { new Guid("d1188aa2-2e45-4f33-abb6-d100f2ea90af"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3739), null, true, "Accounting", null },
                    { new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3744), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4060), null, true, "Civil Engineer", null },
                    { new Guid("1d70c7d5-476d-47f0-850d-f0bef6ac5416"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4049), null, true, "FrontEnd Developer", null },
                    { new Guid("a9c8a255-711f-4280-bcfe-83214d5cc12c"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4056), null, true, "BackEnd Developer", null },
                    { new Guid("b5ba6049-1025-4343-b894-4274bb9880fe"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4067), null, true, "Industrial Engineer", null },
                    { new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4041), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4fe6e866-de1a-4ad0-b809-efd6d288a05d"), "Yenibosna/İstanbul", null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"), null, (byte)0, new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4222), "58963214568", true, new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null },
                    { new Guid("fa1175b9-da8c-49d9-b7ea-106a9e3c072e"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"), null, (byte)1, new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4208), "65803196176", true, new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_DepartmentId",
                table: "Personnels",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_JobId",
                table: "Personnels",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayment_Personnels_PersonId",
                table: "AdvancePayment",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequest_Personnels_PersonId",
                table: "PermissionRequest",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayment_Personnels_PersonId",
                table: "AdvancePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequest_Personnels_PersonId",
                table: "PermissionRequest");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25549a56-8a84-4ccd-85f0-c647f3f83dae"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1512eef0-1c66-440b-9f0c-5d01cc4fd4d8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d1188aa2-2e45-4f33-abb6-d100f2ea90af"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d70c7d5-476d-47f0-850d-f0bef6ac5416"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a9c8a255-711f-4280-bcfe-83214d5cc12c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b5ba6049-1025-4343-b894-4274bb9880fe"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "AnnualPermissionDays",
                table: "AspNetUsers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualTakeAdvanceAmount",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "date",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "FireDate",
                table: "AspNetUsers",
                type: "date",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Gender",
                table: "AspNetUsers",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "AspNetUsers",
                type: "date",
                maxLength: 15,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "AspNetUsers",
                type: "varchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "JobId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "AspNetUsers",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlaceofBirth",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondSurname",
                table: "AspNetUsers",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalDate",
                table: "AdvancePayment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b011d880-d9f4-4b5f-95ec-45b945857427"), "7083d551-9d50-470a-9735-9cbbf6d780fd", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("45055d9f-3b0c-4309-b8bd-a59f3f49832f"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8576), null, true, "HR", null },
                    { new Guid("b526f602-b268-4057-a11e-d92a8ef55029"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8577), null, true, "Accounting", null },
                    { new Guid("d8632eb2-65b5-4d56-8efc-400fa80a66da"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8566), null, true, "Mechanical Design", null },
                    { new Guid("e94abdc9-27aa-4ee8-9315-ff41c134f595"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8579), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("089fd991-c500-4d56-a06b-90c83a9d35d1"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8678), null, true, "Industrial Engineer", null },
                    { new Guid("7e35cefc-a7af-42e5-9c07-44c36860d424"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8677), null, true, "Civil Engineer", null },
                    { new Guid("8c3f19eb-76ad-4915-a607-9c51b406aafe"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8676), null, true, "BackEnd Developer", null },
                    { new Guid("9b72fa1c-d4b0-4d52-820a-f4421197c314"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8674), null, true, "FrontEnd Developer", null },
                    { new Guid("eb15adb6-db80-4f0c-a317-ab5512119234"), new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8672), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("25e208aa-3e8b-425e-93a7-d50287fb1b38"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "de37781a-e32e-4ed7-8e18-3c32b3f3316a", new Guid("d8632eb2-65b5-4d56-8efc-400fa80a66da"), "muhammet.coskun@bilgeadamboost.com", true, null, (byte)0, new DateTime(2023, 12, 2, 17, 38, 47, 242, DateTimeKind.Local).AddTicks(8731), "58963214568", new Guid("7e35cefc-a7af-42e5-9c07-44c36860d424"), false, null, "Muhammet", "MUHAMMET.COSKUN@BILGEADAMBOOST.COM", null, "AQAAAAEAACcQAAAAEDUGjwn3ZkKAHdap6VdliMLRQUZgn1+xgTpDFc/EAyUcgZv2/5l9M5LjFBjHYdTDag==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, null, null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27B", "Coşkun", false, "muhammetcoskun" },
                    { new Guid("8b0547c9-1d75-4b0f-b1ac-c927309a93d0"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "36ee3233-391c-48b9-9c97-de7dd5dd327f", new Guid("e94abdc9-27aa-4ee8-9315-ff41c134f595"), "elifbetul.demir@bilgeadamboost.com", true, null, (byte)1, new DateTime(2023, 12, 2, 17, 38, 47, 236, DateTimeKind.Local).AddTicks(8739), "65803196176", new Guid("eb15adb6-db80-4f0c-a317-ab5512119234"), false, null, "Elif", "ELIFBETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEPHeLcRt4OIvsbAEnjloxYV1293RhtOcqR8xHPa0aBAdpVtfpsushLQp9lCRoETtMg==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27A", "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b011d880-d9f4-4b5f-95ec-45b945857427"), new Guid("8b0547c9-1d75-4b0f-b1ac-c927309a93d0") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayment_AspNetUsers_PersonId",
                table: "AdvancePayment",
                column: "PersonId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequest_AspNetUsers_PersonId",
                table: "PermissionRequest",
                column: "PersonId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
