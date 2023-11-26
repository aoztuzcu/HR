using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("04948ba5-0327-4adb-9b5c-ddc032090b6c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bd1732b5-4567-485b-b1ea-42704b1722ac"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00c6734e-c979-4fa4-a55a-e5dbd8695747"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3c06375c-2a55-4491-82af-2ac21740b990"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fda6bd78-74b8-43e8-8e54-45b68eae8bec"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("e6b84557-7613-4d34-a0dd-5427f55eb25c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("36021849-ed38-4883-9921-709dde874134"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5ea27f3d-87c0-46e5-a47c-4f5f011fac11"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f4fea5f-cc69-4aa3-bc21-27e9c87f168b"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4031), null, true, "Information Technology", null },
                    { new Guid("74d75f89-f6ac-4694-8819-f342378984f3"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4016), null, true, "Mechanical Design", null },
                    { new Guid("80ee0110-a070-46e8-a878-4fd81c77be1e"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4027), null, true, "HR", null },
                    { new Guid("ddba8f2c-f82b-44d2-9fe8-d65a5e9f9018"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4030), null, true, "Accounting", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("087aaa37-cd80-4b8c-9e0e-df14ad47beaa"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4142), null, true, "Industrial Engineer", null },
                    { new Guid("1407d9f6-a962-44f5-8e11-1cf45428e5d9"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4140), null, true, "Civil Engineer", null },
                    { new Guid("6023a06a-f1d9-43c4-85a6-8e4011cf1566"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4139), null, true, "BackEnd Developer", null },
                    { new Guid("b952cbea-4164-4301-ada3-67799de5f789"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4137), null, true, "FrontEnd Developer", null },
                    { new Guid("cb78e605-d193-4278-b88b-fe863adace4a"), new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4131), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "HireDate", "IdentityNumber", "IsActive", "JobId", "Mail", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("87c65b9a-c45b-40ce-ab6f-8651e915a8e2"), "Kadıköy/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4155), null, new Guid("0f4fea5f-cc69-4aa3-bc21-27e9c87f168b"), null, new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4158), "65803196176", true, new Guid("cb78e605-d193-4278-b88b-fe863adace4a"), null, "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("f78c3271-f75a-4838-8fc4-107332d31500"), "Yenibosna/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4165), null, new Guid("74d75f89-f6ac-4694-8819-f342378984f3"), null, new DateTime(2023, 11, 27, 0, 33, 10, 962, DateTimeKind.Local).AddTicks(4166), "65803196176", true, new Guid("1407d9f6-a962-44f5-8e11-1cf45428e5d9"), null, "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("80ee0110-a070-46e8-a878-4fd81c77be1e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ddba8f2c-f82b-44d2-9fe8-d65a5e9f9018"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("087aaa37-cd80-4b8c-9e0e-df14ad47beaa"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6023a06a-f1d9-43c4-85a6-8e4011cf1566"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b952cbea-4164-4301-ada3-67799de5f789"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("87c65b9a-c45b-40ce-ab6f-8651e915a8e2"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("f78c3271-f75a-4838-8fc4-107332d31500"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0f4fea5f-cc69-4aa3-bc21-27e9c87f168b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("74d75f89-f6ac-4694-8819-f342378984f3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1407d9f6-a962-44f5-8e11-1cf45428e5d9"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("cb78e605-d193-4278-b88b-fe863adace4a"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("04948ba5-0327-4adb-9b5c-ddc032090b6c"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(9), null, true, "HR", null },
                    { new Guid("36021849-ed38-4883-9921-709dde874134"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(30), null, true, "Information Technology", null },
                    { new Guid("bd1732b5-4567-485b-b1ea-42704b1722ac"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(29), null, true, "Accounting", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00c6734e-c979-4fa4-a55a-e5dbd8695747"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(128), null, true, "BackEnd Developer", null },
                    { new Guid("3c06375c-2a55-4491-82af-2ac21740b990"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(132), null, true, "Industrial Engineer", null },
                    { new Guid("5ea27f3d-87c0-46e5-a47c-4f5f011fac11"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(124), null, true, "Software Developer", null },
                    { new Guid("fda6bd78-74b8-43e8-8e54-45b68eae8bec"), new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(126), null, true, "FrontEnd Developer", null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Address", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "HireDate", "IdentityNumber", "IsActive", "JobId", "Mail", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[] { new Guid("e6b84557-7613-4d34-a0dd-5427f55eb25c"), "Kadıköy/İstanbul", new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(146), null, new Guid("36021849-ed38-4883-9921-709dde874134"), null, new DateTime(2023, 11, 27, 0, 23, 18, 301, DateTimeKind.Local).AddTicks(149), "65803196176", true, new Guid("5ea27f3d-87c0-46e5-a47c-4f5f011fac11"), null, "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null });
        }
    }
}
