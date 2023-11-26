using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8116f89b-77a2-4424-9004-a5f058e77000"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9a9f709-d604-4324-a4ae-83265f52c456"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fb48b2b7-d798-4868-8831-3546f89dc7b2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6edb8a1f-dab2-402d-ab3b-5b5cb70c5a43"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7e80b935-c15d-41cd-bdb1-2d25ddaae57d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("845db393-77c1-4937-9abd-139537fab852"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("93336820-b009-415c-940b-ad7198095a9c"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("24504905-f22c-4c77-b8f2-94ae27ee37a4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2f8cf8c9-e9c0-4668-9f8e-0c16215be3c3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7d87abb0-1840-4e40-9b5e-407b6b746307"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3027bdaf-9bfe-4142-b6eb-5251a39105ba"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8011), null, true, "Information Technology", null },
                    { new Guid("61260eba-550d-4e3d-87cd-0b56976b3c1e"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(7987), null, true, "HR", null },
                    { new Guid("61d46816-f5f9-4d85-9170-c7405724e003"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(7966), null, true, "Mechanical Design", null },
                    { new Guid("80ed70bb-473a-49be-89b8-2798f05e682b"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8008), null, true, "Accounting", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2e01cff9-9e58-4384-a595-a2b49ede1bd3"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8308), null, true, "FrontEnd Developer", null },
                    { new Guid("a4f3ebd5-529c-4f6f-9f56-c356ae70b745"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8302), null, true, "Software Developer", null },
                    { new Guid("a8f2e627-46a4-4613-b46c-35fecb888157"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8332), null, true, "Industrial Engineer", null },
                    { new Guid("ba0ec97b-2a23-43cd-8641-d97516e40a0e"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8314), null, true, "BackEnd Developer", null },
                    { new Guid("ce51c1ae-98c6-430d-b313-8302eb556d02"), new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8327), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "HireDate", "IdentityNumber", "IsActive", "JobId", "Mail", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[] { new Guid("b6f37500-cfd3-4968-9d76-71091665e28a"), "Kadıköy/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8370), null, new Guid("3027bdaf-9bfe-4142-b6eb-5251a39105ba"), null, new DateTime(2023, 11, 26, 22, 44, 31, 492, DateTimeKind.Local).AddTicks(8376), "65803196176", true, new Guid("a4f3ebd5-529c-4f6f-9f56-c356ae70b745"), "Elif.Demir@bilgeadam.com", "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("61260eba-550d-4e3d-87cd-0b56976b3c1e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("61d46816-f5f9-4d85-9170-c7405724e003"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("80ed70bb-473a-49be-89b8-2798f05e682b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2e01cff9-9e58-4384-a595-a2b49ede1bd3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a8f2e627-46a4-4613-b46c-35fecb888157"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ba0ec97b-2a23-43cd-8641-d97516e40a0e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ce51c1ae-98c6-430d-b313-8302eb556d02"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("b6f37500-cfd3-4968-9d76-71091665e28a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3027bdaf-9bfe-4142-b6eb-5251a39105ba"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a4f3ebd5-529c-4f6f-9f56-c356ae70b745"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2f8cf8c9-e9c0-4668-9f8e-0c16215be3c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Information Technology", null },
                    { new Guid("8116f89b-77a2-4424-9004-a5f058e77000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Accounting", null },
                    { new Guid("f9a9f709-d604-4324-a4ae-83265f52c456"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Mechanical Design", null },
                    { new Guid("fb48b2b7-d798-4868-8831-3546f89dc7b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6edb8a1f-dab2-402d-ab3b-5b5cb70c5a43"), new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(356), null, true, "Industrial Engineer", null },
                    { new Guid("7d87abb0-1840-4e40-9b5e-407b6b746307"), new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(336), null, true, "Software Developer", null },
                    { new Guid("7e80b935-c15d-41cd-bdb1-2d25ddaae57d"), new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(347), null, true, "FrontEnd Developer", null },
                    { new Guid("845db393-77c1-4937-9abd-139537fab852"), new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(354), null, true, "Civil Engineer", null },
                    { new Guid("93336820-b009-415c-940b-ad7198095a9c"), new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(352), null, true, "BackEnd Developer", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "HireDate", "IdentityNumber", "IsActive", "JobId", "Mail", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[] { new Guid("24504905-f22c-4c77-b8f2-94ae27ee37a4"), "Kadıköy/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(412), null, new Guid("2f8cf8c9-e9c0-4668-9f8e-0c16215be3c3"), null, new DateTime(2023, 11, 26, 22, 41, 29, 790, DateTimeKind.Local).AddTicks(416), "65803196176", true, new Guid("7d87abb0-1840-4e40-9b5e-407b6b746307"), "Elif.Demir@bilgeadam.com", "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null });
        }
    }
}
