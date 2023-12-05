using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6d386e90-74ab-4f16-ba38-459324a7225c"), "e7c6c0c8-d661-4844-a15d-65a494ab55a4", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("24e20af5-8e56-4ba0-9ecb-8abe14917d9b"), 0, "90b731cb-ad7a-4c3e-8a4b-199043c6b9c2", "betul.demir@bilgeadamboost.com", true, false, null, "Betül", "BETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEOgF/Po8zs5r1+euDG5Mu0VllwA9HBPhR/iUxhStxvYgv0X52etqj2BVNtr61d7pNw==", null, false, "515f3052-2538-4a0c-bc81-a0d34be42d76", "Demir", false, "betuldemir" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("072672d9-d4ca-4d55-b61e-fac01d39a7a3"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8265), null, true, "Mekanik Tasarım", null },
                    { new Guid("5e21e779-0ab0-4c8e-97f6-49295a0ee812"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8290), null, true, "Muhasebe", null },
                    { new Guid("d88ecbc6-bff9-4786-a89c-ecb99d3e8dd3"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8293), null, true, "Bilişim Teknolojileri", null },
                    { new Guid("e4b93ee8-1196-41f4-b7f4-a34d0df2139e"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8284), null, true, "İnsan Kaynakları", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("4548cad9-76ad-4c6f-aa92-94814e0f7335"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8398), null, true, "İnşaat Mühendisi", null },
                    { new Guid("5ecf7a22-61ec-44be-8c25-3b09844e8a07"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8395), null, true, "BackEnd Geliştici", null },
                    { new Guid("91380c24-4dfd-4094-88a2-a85f0951cc1f"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8402), null, true, "Endüstri Mühendisi", null },
                    { new Guid("bbd6ab5b-e2ef-4b44-be69-96900f25627d"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8382), null, true, "Yazılım Mühendisi", null },
                    { new Guid("be57df39-b57e-43bb-af48-9052d3600ad1"), new DateTime(2023, 12, 5, 22, 56, 23, 132, DateTimeKind.Local).AddTicks(8391), null, true, "FrontEnd Geliştici", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d386e90-74ab-4f16-ba38-459324a7225c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24e20af5-8e56-4ba0-9ecb-8abe14917d9b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("072672d9-d4ca-4d55-b61e-fac01d39a7a3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5e21e779-0ab0-4c8e-97f6-49295a0ee812"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d88ecbc6-bff9-4786-a89c-ecb99d3e8dd3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e4b93ee8-1196-41f4-b7f4-a34d0df2139e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4548cad9-76ad-4c6f-aa92-94814e0f7335"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5ecf7a22-61ec-44be-8c25-3b09844e8a07"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("91380c24-4dfd-4094-88a2-a85f0951cc1f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("bbd6ab5b-e2ef-4b44-be69-96900f25627d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("be57df39-b57e-43bb-af48-9052d3600ad1"));
        }
    }
}
