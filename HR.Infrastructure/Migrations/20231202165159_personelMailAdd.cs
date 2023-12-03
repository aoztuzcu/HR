using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class personelMailAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25549a56-8a84-4ccd-85f0-c647f3f83dae"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1512eef0-1c66-440b-9f0c-5d01cc4fd4d8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d1188aa2-2e45-4f33-abb6-d100f2ea90af"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1d70c7d5-476d-47f0-850d-f0bef6ac5416"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a9c8a255-711f-4280-bcfe-83214d5cc12c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b5ba6049-1025-4343-b894-4274bb9880fe"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("4fe6e866-de1a-4ad0-b809-efd6d288a05d"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("fa1175b9-da8c-49d9-b7ea-106a9e3c072e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("4eb3dd15-f85f-40fb-bb26-48f0badc7b61"), "8a0f1e97-2c57-4a6b-99fa-9353d077a728", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("cefc4d34-ede7-4740-9b79-19d9cae99188"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8700), null, true, "Accounting", null },
                    { new Guid("d8011052-8221-49a1-ac29-5f4ee3f73cd5"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8706), null, true, "Information Technology", null },
                    { new Guid("df522ce1-7f1e-4fe7-b946-effe43e17ae7"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8696), null, true, "HR", null },
                    { new Guid("f44d1474-2db3-4d29-954b-bc49f689d34f"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8677), null, true, "Mechanical Design", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2209fa01-1a30-4160-bae3-47eaae940375"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8880), null, true, "Industrial Engineer", null },
                    { new Guid("4e93d9ca-da40-4caa-b31b-13194669bfae"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8871), null, true, "BackEnd Developer", null },
                    { new Guid("785f64cf-5b2d-4564-a95b-f3b3d696b800"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8868), null, true, "FrontEnd Developer", null },
                    { new Guid("8550bf77-4120-4fd6-8438-e135673995c4"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8863), null, true, "Software Developer", null },
                    { new Guid("c1fdee91-1ce6-41d7-91a2-8e157051cc8a"), new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8873), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "Email", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8419d3fd-46c6-4467-ba01-f8b66a310959"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d8011052-8221-49a1-ac29-5f4ee3f73cd5"), "betul.demir@bilgeadamboost.com", null, (byte)1, new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8977), "65803196176", true, new Guid("8550bf77-4120-4fd6-8438-e135673995c4"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("d2feb5b1-8630-45b2-8bd4-75268d0e195f"), "Yenibosna/İstanbul", null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f44d1474-2db3-4d29-954b-bc49f689d34f"), "muhammet.coskun@bilgeadamboost.com", null, (byte)0, new DateTime(2023, 12, 2, 19, 51, 59, 579, DateTimeKind.Local).AddTicks(8986), "58963214568", true, new Guid("c1fdee91-1ce6-41d7-91a2-8e157051cc8a"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4eb3dd15-f85f-40fb-bb26-48f0badc7b61"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cefc4d34-ede7-4740-9b79-19d9cae99188"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("df522ce1-7f1e-4fe7-b946-effe43e17ae7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2209fa01-1a30-4160-bae3-47eaae940375"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4e93d9ca-da40-4caa-b31b-13194669bfae"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("785f64cf-5b2d-4564-a95b-f3b3d696b800"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("8419d3fd-46c6-4467-ba01-f8b66a310959"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("d2feb5b1-8630-45b2-8bd4-75268d0e195f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d8011052-8221-49a1-ac29-5f4ee3f73cd5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f44d1474-2db3-4d29-954b-bc49f689d34f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8550bf77-4120-4fd6-8438-e135673995c4"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c1fdee91-1ce6-41d7-91a2-8e157051cc8a"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personnels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("25549a56-8a84-4ccd-85f0-c647f3f83dae"), "23e3ecf8-ebd3-4e1f-8ba2-a4334f871b8f", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1512eef0-1c66-440b-9f0c-5d01cc4fd4d8"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3732), null, true, "HR", null },
                    { new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3718), null, true, "Mechanical Design", null },
                    { new Guid("d1188aa2-2e45-4f33-abb6-d100f2ea90af"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3739), null, true, "Accounting", null },
                    { new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(3744), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4060), null, true, "Civil Engineer", null },
                    { new Guid("1d70c7d5-476d-47f0-850d-f0bef6ac5416"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4049), null, true, "FrontEnd Developer", null },
                    { new Guid("a9c8a255-711f-4280-bcfe-83214d5cc12c"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4056), null, true, "BackEnd Developer", null },
                    { new Guid("b5ba6049-1025-4343-b894-4274bb9880fe"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4067), null, true, "Industrial Engineer", null },
                    { new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"), new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4041), null, true, "Software Developer", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4fe6e866-de1a-4ad0-b809-efd6d288a05d"), "Yenibosna/İstanbul", null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("442a40e1-b09f-4a69-94ba-050ff3692f9d"), null, (byte)0, new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4222), "58963214568", true, new Guid("0af134c8-303b-4290-9e7f-fda5a093b038"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null },
                    { new Guid("fa1175b9-da8c-49d9-b7ea-106a9e3c072e"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("f9c72d33-0f39-4a05-b33b-3a8b23a36a51"), null, (byte)1, new DateTime(2023, 12, 2, 19, 45, 27, 18, DateTimeKind.Local).AddTicks(4208), "65803196176", true, new Guid("ca5656df-a8d0-4f14-8719-0764a95a59bd"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null }
                });
        }
    }
}
