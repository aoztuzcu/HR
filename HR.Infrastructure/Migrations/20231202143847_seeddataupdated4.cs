using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeddataupdated4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("84406e07-015d-4817-a186-145105e291ac"), new Guid("32a95626-37cd-494d-a8cd-1dc67b53af40") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10a424d1-f935-49a8-a4c3-e04881334a36"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3c5cb7f6-bb3a-4785-b7a3-3334657fa869"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d4144335-8078-4b75-8cd1-129498f8779d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("91319ff9-7708-42f2-be55-96138c3bf213"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("cc934a66-6af6-41e8-9491-1e16a9f42ceb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ed5a2c45-2fe4-4fdd-941f-73c9aafd38c9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("84406e07-015d-4817-a186-145105e291ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("32a95626-37cd-494d-a8cd-1dc67b53af40"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f7886d2c-8e87-4a53-8508-2a571d08adaa"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5a25d01c-8b9f-493d-9b9c-f96735135a9e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4725100f-ce05-46de-8b5c-3cf5131132a8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a98baad3-c901-49fd-bfb0-4a36ec70429a"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("84406e07-015d-4817-a186-145105e291ac"), "1974e7b3-fc2e-4b1e-bec9-cd0041adc767", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3c5cb7f6-bb3a-4785-b7a3-3334657fa869"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1073), null, true, "Accounting", null },
                    { new Guid("4725100f-ce05-46de-8b5c-3cf5131132a8"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1079), null, true, "Information Technology", null },
                    { new Guid("d4144335-8078-4b75-8cd1-129498f8779d"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1071), null, true, "HR", null },
                    { new Guid("f7886d2c-8e87-4a53-8508-2a571d08adaa"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1059), null, true, "Mechanical Design", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("5a25d01c-8b9f-493d-9b9c-f96735135a9e"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1250), null, true, "Civil Engineer", null },
                    { new Guid("91319ff9-7708-42f2-be55-96138c3bf213"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1248), null, true, "BackEnd Developer", null },
                    { new Guid("a98baad3-c901-49fd-bfb0-4a36ec70429a"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1244), null, true, "Software Developer", null },
                    { new Guid("cc934a66-6af6-41e8-9491-1e16a9f42ceb"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1246), null, true, "FrontEnd Developer", null },
                    { new Guid("ed5a2c45-2fe4-4fdd-941f-73c9aafd38c9"), new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1256), null, true, "Industrial Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10a424d1-f935-49a8-a4c3-e04881334a36"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "67d85ea3-52b3-42b0-a40c-a5d81cd3a6e4", new Guid("f7886d2c-8e87-4a53-8508-2a571d08adaa"), "muhammet.coskun@bilgeadamboost.com", true, null, (byte)0, new DateTime(2023, 12, 2, 16, 16, 48, 155, DateTimeKind.Local).AddTicks(1176), "58963214568", new Guid("5a25d01c-8b9f-493d-9b9c-f96735135a9e"), false, null, "Muhammet", "MUHAMMET.COSKUN@BILGEADAMBOOST.COM", null, "AQAAAAEAACcQAAAAEG+CVx8c1dnTUdFlU5OnTC04rVbDHbevzDChSIG+ZtBqzlAv2MXqStHdgOAz/0czkA==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, null, null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27B", "Coşkun", false, "muhammetcoskun" },
                    { new Guid("32a95626-37cd-494d-a8cd-1dc67b53af40"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "5f2ffc37-4c2f-4355-bbe0-c4acb24cc263", new Guid("4725100f-ce05-46de-8b5c-3cf5131132a8"), "elifbetul.demir@bilgeadamboost.com", true, null, (byte)1, new DateTime(2023, 12, 2, 16, 16, 48, 147, DateTimeKind.Local).AddTicks(1332), "65803196176", new Guid("a98baad3-c901-49fd-bfb0-4a36ec70429a"), false, null, "Elif", "ELIFBETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEGXnpbvcMHxmNOh+Wy/0KSzdOrCTiZxx9BHsDU0A7qXEf6/qMt021I/Y0U4n1OgpdA==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27A", "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("84406e07-015d-4817-a186-145105e291ac"), new Guid("32a95626-37cd-494d-a8cd-1dc67b53af40") });
        }
    }
}
