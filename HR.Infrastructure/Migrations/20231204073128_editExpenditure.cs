using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editExpenditure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa53fa86-78e7-4ceb-b8dc-a16c915135cf"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("37c1ea4e-04ec-4cba-a148-91d96f35330a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6b78e259-e7b7-45c8-bc54-d90b1ec60745"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("506e1347-ae85-47d5-8939-2bbbd4709a6e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e7eb587e-a32d-4235-a6a1-427c3077f8b8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fe658b13-6c02-498f-991c-94b7fb1b6816"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("85f9b174-32f3-418e-99f8-35e36d9c6d75"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e299506c-447a-4ceb-aaa7-5793f8860751"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1cde1d6c-23ea-4d87-8ac2-8629941fcec2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7049ffe1-32a1-41e4-84c3-1309b4ac3598"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d9da4da4-6128-4f83-b8a1-6850245e7340"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fa976ad0-472e-4e47-900b-acfc8e1ac4e2"));

            migrationBuilder.AddColumn<decimal>(
                name: "MaxAmount",
                table: "ExpenditureTypes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MinAmount",
                table: "ExpenditureTypes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeAmount",
                table: "Expenditures",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("38627780-5488-4603-bf58-0fc3effb909d"), "83e0bf0c-f619-4cce-bd9c-0876035be521", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2839f286-c556-4fa7-8fd1-a058365b55e3"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3935), null, true, "İnsan Kaynakları", null },
                    { new Guid("47ffa12f-1b14-4894-be08-0e13a9adaadb"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3937), null, true, "Muhasebe", null },
                    { new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3917), null, true, "Mekanik Tasarım", null },
                    { new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(3938), null, true, "Bilişim Teknolojileri", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ee3ab68-3ff8-49a3-b55d-dfa550f3a4fb"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4106), null, true, "BackEnd Geliştici", null },
                    { new Guid("7136d9fb-50d9-4e6b-8585-e5ae612e396f"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4104), null, true, "FrontEnd Geliştici", null },
                    { new Guid("9335a9e3-c097-4f51-a907-d6c223f8e473"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4110), null, true, "Endüstri Mühendisi", null },
                    { new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4102), null, true, "Yazılım Mühendisi", null },
                    { new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4108), null, true, "İnşaat Mühendisi", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "Email", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"), "betul.demir@bilgeadamboost.com", null, (byte)1, new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4177), "65803196176", true, new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"), "Yenibosna/İstanbul", null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"), "muhammet.coskun@bilgeadamboost.com", null, (byte)0, new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4185), "58963214568", true, new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("38627780-5488-4603-bf58-0fc3effb909d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2839f286-c556-4fa7-8fd1-a058365b55e3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("47ffa12f-1b14-4894-be08-0e13a9adaadb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0ee3ab68-3ff8-49a3-b55d-dfa550f3a4fb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7136d9fb-50d9-4e6b-8585-e5ae612e396f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9335a9e3-c097-4f51-a907-d6c223f8e473"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"));

            migrationBuilder.DropColumn(
                name: "MaxAmount",
                table: "ExpenditureTypes");

            migrationBuilder.DropColumn(
                name: "MinAmount",
                table: "ExpenditureTypes");

            migrationBuilder.DropColumn(
                name: "ExchangeAmount",
                table: "Expenditures");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("fa53fa86-78e7-4ceb-b8dc-a16c915135cf"), "0e8eb92b-200f-4e40-999d-033dc721ce14", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1cde1d6c-23ea-4d87-8ac2-8629941fcec2"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(588), null, true, "Information Technology", null },
                    { new Guid("37c1ea4e-04ec-4cba-a148-91d96f35330a"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(582), null, true, "HR", null },
                    { new Guid("6b78e259-e7b7-45c8-bc54-d90b1ec60745"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(587), null, true, "Accounting", null },
                    { new Guid("7049ffe1-32a1-41e4-84c3-1309b4ac3598"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(572), null, true, "Mechanical Design", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("506e1347-ae85-47d5-8939-2bbbd4709a6e"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(765), null, true, "BackEnd Developer", null },
                    { new Guid("d9da4da4-6128-4f83-b8a1-6850245e7340"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(770), null, true, "Civil Engineer", null },
                    { new Guid("e7eb587e-a32d-4235-a6a1-427c3077f8b8"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(764), null, true, "FrontEnd Developer", null },
                    { new Guid("fa976ad0-472e-4e47-900b-acfc8e1ac4e2"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(761), null, true, "Software Developer", null },
                    { new Guid("fe658b13-6c02-498f-991c-94b7fb1b6816"), new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(771), null, true, "Industrial Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "Email", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("85f9b174-32f3-418e-99f8-35e36d9c6d75"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1cde1d6c-23ea-4d87-8ac2-8629941fcec2"), "betul.demir@bilgeadamboost.com", null, (byte)1, new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(828), "65803196176", true, new Guid("fa976ad0-472e-4e47-900b-acfc8e1ac4e2"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("e299506c-447a-4ceb-aaa7-5793f8860751"), "Yenibosna/İstanbul", null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7049ffe1-32a1-41e4-84c3-1309b4ac3598"), "muhammet.coskun@bilgeadamboost.com", null, (byte)0, new DateTime(2023, 12, 2, 22, 33, 42, 126, DateTimeKind.Local).AddTicks(838), "58963214568", true, new Guid("d9da4da4-6128-4f83-b8a1-6850245e7340"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }
    }
}
