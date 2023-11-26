using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("30e3eda5-ccf2-4ac9-91fc-2cba2f7d8115"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b1cc6787-4ac2-4195-9f81-db09cb35e078"));

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
                keyValue: new Guid("e4e7537f-be94-4fc5-892d-8b8027dca82a"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("55a8d686-dea1-4331-8428-3fd8f475412d"));

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: new Guid("78516afa-1058-4808-8da2-6b79dc0592fb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1bf71988-0398-45e3-8ad0-d7f53aa8bc5d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("bbb9495e-a877-48bf-b4e9-2a3263627849"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("dd1aab46-b4ce-449d-8c27-151f7ef4f566"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f9b0d612-6e20-4755-b726-d5cb619527f8"));

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
    }
}
