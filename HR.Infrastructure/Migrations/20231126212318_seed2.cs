using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "People",
                type: "varchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Mail",
                table: "People",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

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
    }
}
