using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
