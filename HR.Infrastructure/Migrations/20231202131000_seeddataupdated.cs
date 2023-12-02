using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeddataupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6eda59d-c41f-40c7-98e2-a77f7e5de27d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1022a8d1-493f-4e45-8343-426d1c9ced0c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f230ea80-2ecc-46db-ae41-680948e854dd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("05cd27e7-f17d-4ca6-86e9-23fc1d5722a1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("cc8fcab2-f7c0-41ed-9110-997aaaf2c5be"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ecf58c4a-cc11-465d-8042-861fd8db85ff"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), "739fe878-870d-4daf-b030-af8a3cfe1752", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1022a8d1-493f-4e45-8343-426d1c9ced0c"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9696), null, true, "Accounting", null },
                    { new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9698), null, true, "Information Technology", null },
                    { new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9670), null, true, "Mechanical Design", null },
                    { new Guid("f230ea80-2ecc-46db-ae41-680948e854dd"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9686), null, true, "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("05cd27e7-f17d-4ca6-86e9-23fc1d5722a1"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9940), null, true, "FrontEnd Developer", null },
                    { new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9935), null, true, "Software Developer", null },
                    { new Guid("cc8fcab2-f7c0-41ed-9110-997aaaf2c5be"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9955), null, true, "Industrial Engineer", null },
                    { new Guid("ecf58c4a-cc11-465d-8042-861fd8db85ff"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9943), null, true, "BackEnd Developer", null },
                    { new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9946), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "4c30db44-6a2a-4b10-a73f-bfa862e89ffa", new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 15, 18, 23, 885, DateTimeKind.Local).AddTicks(4031), "58963214568", new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"), false, null, "Muhammet", null, null, "AQAAAAEAACcQAAAAEPDobBDXvslRT/Q4ldkMz0NpxB3xC2JGdC/LncyzAPMEgCWVU2XgGFeuyDcNCopnFg==", "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, "muhammetcoskun" },
                    { new Guid("e6eda59d-c41f-40c7-98e2-a77f7e5de27d"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "b7b30bc4-8a06-47ac-af99-d08ca9182f4f", new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"), null, false, null, (byte)1, new DateTime(2023, 12, 2, 15, 18, 23, 872, DateTimeKind.Local).AddTicks(81), "65803196176", new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"), false, null, "Elif", null, null, "AQAAAAEAACcQAAAAEFYczEkibHVzbRnDLeKVevv9UNqK8MT568BN05VK+ulob5WEBL5I2WXrR4oRWDKGzA==", "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb") });
        }
    }
}
