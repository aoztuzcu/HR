using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeddataupdated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26ba8d47-2604-4681-9de1-056231262487"), new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8bf129c4-9162-412d-a7a7-b7021aa43ad2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5cf0c63f-eb64-42f0-a202-ff67ef7d81a4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8699c42f-32cb-480e-ad9c-6de13895720c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("66c12bd3-c43b-4bd3-bf03-c5c7b2162b71"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9435d648-4fd7-42a7-a7a2-8ae545f62a3d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a5221e58-7f87-471c-ac60-2f36df08b23e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26ba8d47-2604-4681-9de1-056231262487"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0f57c7a-b333-452b-8f64-d818ade5620f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f62cc891-91b3-4430-9c39-b45f50b3e5d0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ba50568a-3794-41f4-bd65-8a9248a2e0dd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b1e8446-8459-4e35-8bd8-af7ff0e2c5ee"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("26ba8d47-2604-4681-9de1-056231262487"), "46005c23-dc45-4ce9-8ecd-c66d7a51ec97", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("5cf0c63f-eb64-42f0-a202-ff67ef7d81a4"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3091), null, true, "Accounting", null },
                    { new Guid("8699c42f-32cb-480e-ad9c-6de13895720c"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3083), null, true, "HR", null },
                    { new Guid("ba50568a-3794-41f4-bd65-8a9248a2e0dd"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3056), null, true, "Mechanical Design", null },
                    { new Guid("e0f57c7a-b333-452b-8f64-d818ade5620f"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3095), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4b1e8446-8459-4e35-8bd8-af7ff0e2c5ee"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3411), null, true, "Civil Engineer", null },
                    { new Guid("66c12bd3-c43b-4bd3-bf03-c5c7b2162b71"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3409), null, true, "BackEnd Developer", null },
                    { new Guid("9435d648-4fd7-42a7-a7a2-8ae545f62a3d"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3400), null, true, "FrontEnd Developer", null },
                    { new Guid("a5221e58-7f87-471c-ac60-2f36df08b23e"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3415), null, true, "Industrial Engineer", null },
                    { new Guid("f62cc891-91b3-4430-9c39-b45f50b3e5d0"), new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3395), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "d1e8b12d-2d25-4244-a23f-cb00b22189ef", new Guid("ba50568a-3794-41f4-bd65-8a9248a2e0dd"), "muhammet.coskun@bilgeadamboost.com", true, null, (byte)0, new DateTime(2023, 12, 2, 16, 13, 1, 788, DateTimeKind.Local).AddTicks(6315), "58963214568", new Guid("4b1e8446-8459-4e35-8bd8-af7ff0e2c5ee"), false, null, "Muhammet", "MUHAMMET.COSKUN@BILGEADAMBOOST.COM", null, "AQAAAAEAACcQAAAAEKON50WddSvkqYkCHhba7qNgWQiCa+0zLzFl0xnrdKGSBFK5flhM2uWtWPyG4b93pw==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, null, null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27B", "Coşkun", false, "muhammetcoskun" },
                    { new Guid("8bf129c4-9162-412d-a7a7-b7021aa43ad2"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "fd524119-839a-4568-a7c4-a85d9c6b0291", new Guid("e0f57c7a-b333-452b-8f64-d818ade5620f"), "elifbetul.demir@bilgeadamboost.com", true, null, (byte)1, new DateTime(2023, 12, 2, 16, 13, 1, 776, DateTimeKind.Local).AddTicks(3591), "65803196176", new Guid("f62cc891-91b3-4430-9c39-b45f50b3e5d0"), false, null, "Elif", "ELIFBETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEBxoXj6J5dzutsIExlEpCfQk2KLPGrEz7tATMEP44fCffgysTWH7C9Re5lMq7pwGGQ==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "D2C7BG653KANTFOB6NNHCOSN2R7GM27A", "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("26ba8d47-2604-4681-9de1-056231262487"), new Guid("3b52c80b-fb9e-4680-93ed-39f01cff26b7") });
        }
    }
}
