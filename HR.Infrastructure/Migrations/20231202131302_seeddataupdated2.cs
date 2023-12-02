using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeddataupdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("89745752-cecb-454e-9e2a-838be1668253"), new Guid("d92a1d12-1ce4-4186-bb9c-f8dc8ef22c0a") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("17ab1c7b-504e-45fd-a3a6-e45fa5065073"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6b6d61c7-7d08-475d-95be-8e4539f81edb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8115f68d-3968-4a84-aa63-7d43b9eed2bd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0301b010-5a0b-4143-a725-bc575b1c3e85"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6864fb62-6f73-4db0-828b-ef0540ca6207"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("92f72ac2-eb60-44b6-bf39-28c4dc8c6ecc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("89745752-cecb-454e-9e2a-838be1668253"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d92a1d12-1ce4-4186-bb9c-f8dc8ef22c0a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6f2c7722-5f91-46cc-a3df-53009c956974"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b7c325ad-387b-42d4-8535-d62fddec4358"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0052100d-a7d7-4991-9ad6-01044f3fbe70"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2f36259d-249d-4a72-b84e-b25946ebdfee"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("89745752-cecb-454e-9e2a-838be1668253"), "08c7c6c6-4ca6-4e0d-b4b8-c0457869ae01", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0052100d-a7d7-4991-9ad6-01044f3fbe70"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(392), null, true, "Mechanical Design", null },
                    { new Guid("6b6d61c7-7d08-475d-95be-8e4539f81edb"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(410), null, true, "Accounting", null },
                    { new Guid("6f2c7722-5f91-46cc-a3df-53009c956974"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(412), null, true, "Information Technology", null },
                    { new Guid("8115f68d-3968-4a84-aa63-7d43b9eed2bd"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(407), null, true, "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0301b010-5a0b-4143-a725-bc575b1c3e85"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(594), null, true, "BackEnd Developer", null },
                    { new Guid("2f36259d-249d-4a72-b84e-b25946ebdfee"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(596), null, true, "Civil Engineer", null },
                    { new Guid("6864fb62-6f73-4db0-828b-ef0540ca6207"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(599), null, true, "Industrial Engineer", null },
                    { new Guid("92f72ac2-eb60-44b6-bf39-28c4dc8c6ecc"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(592), null, true, "FrontEnd Developer", null },
                    { new Guid("b7c325ad-387b-42d4-8535-d62fddec4358"), new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(582), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("17ab1c7b-504e-45fd-a3a6-e45fa5065073"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "336e404e-c20b-4e5e-81ee-091aee762e15", new Guid("6f2c7722-5f91-46cc-a3df-53009c956974"), "elifbetul.demir@bilgeadamboost.com", true, null, (byte)1, new DateTime(2023, 12, 2, 16, 10, 0, 478, DateTimeKind.Local).AddTicks(689), "65803196176", new Guid("b7c325ad-387b-42d4-8535-d62fddec4358"), false, null, "Elif", "ELIFBETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEOYpCXbXBvtm/9xqSE6EVfZckuWZPpjjiE78A3NdqfCWK5TlmFQHg26bLbjZxZoVxg==", "5226932145", true, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, "betuldemir" },
                    { new Guid("d92a1d12-1ce4-4186-bb9c-f8dc8ef22c0a"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "493045a3-38a0-46ce-a52d-d180c64a473b", new Guid("0052100d-a7d7-4991-9ad6-01044f3fbe70"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 16, 10, 0, 488, DateTimeKind.Local).AddTicks(9772), "58963214568", new Guid("2f36259d-249d-4a72-b84e-b25946ebdfee"), false, null, "Muhammet", null, null, "AQAAAAEAACcQAAAAELh+uY8+pUU1Dn3QQLDXZnncjNM4I4u9PEbJ2VUJqWrJe5Vn5+nlmYcmLPZgqOJOIw==", "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, "muhammetcoskun" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("89745752-cecb-454e-9e2a-838be1668253"), new Guid("d92a1d12-1ce4-4186-bb9c-f8dc8ef22c0a") });
        }
    }
}
