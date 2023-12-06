using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class permissionupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d2a0344-0e6a-40f0-9a10-69595013d7f6"), "3e6f11ca-487b-477a-9b5b-f88279600ac1", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b38ef9fd-c744-4234-b27d-0b810a92d3e0"), 0, "d609f956-f60e-4722-99ee-763b53241a63", "betul.demir@bilgeadamboost.com", true, false, null, "Betül", "BETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEJt9rzSc3mESH36YVPXb9+hVNu9Sw+JNV7PGZaYp0/yyWdBmokR1umw2l8qtKgshpQ==", null, false, "e743696f-ba13-47b0-8691-6712451962a4", "Demir", false, "betuldemir" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("9ee9b72b-53d4-4a8c-925e-8d6226bc548e"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(580), null, true, "Mekanik Tasarım", null },
                    { new Guid("cfba4ff2-193a-4c23-8a7a-0af7ef59cba5"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(592), null, true, "İnsan Kaynakları", null },
                    { new Guid("ecf9dfd4-ffbf-4cc5-881a-9ea01a157676"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(595), null, true, "Bilişim Teknolojileri", null },
                    { new Guid("fd785b3b-badd-4db4-b1a3-89a6cfa5aaa3"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(594), null, true, "Muhasebe", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("182f23fa-5d66-4c41-b56a-b0e2907ba0e7"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(617), null, true, "Yazılım Mühendisi", null },
                    { new Guid("34ba3f39-b45b-4145-a4e9-f80c87391bac"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(729), null, true, "İnşaat Mühendisi", null },
                    { new Guid("43697877-eb21-42a8-b4c0-b0b8124a3841"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(621), null, true, "FrontEnd Geliştici", null },
                    { new Guid("5db166f5-a56a-4ea3-953d-c602e45ad876"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(623), null, true, "BackEnd Geliştici", null },
                    { new Guid("ef8ce3bb-c3fc-49ab-9ed6-50da2458f6da"), new DateTime(2023, 12, 6, 18, 13, 30, 187, DateTimeKind.Local).AddTicks(731), null, true, "Endüstri Mühendisi", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d2a0344-0e6a-40f0-9a10-69595013d7f6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b38ef9fd-c744-4234-b27d-0b810a92d3e0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9ee9b72b-53d4-4a8c-925e-8d6226bc548e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cfba4ff2-193a-4c23-8a7a-0af7ef59cba5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ecf9dfd4-ffbf-4cc5-881a-9ea01a157676"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fd785b3b-badd-4db4-b1a3-89a6cfa5aaa3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("182f23fa-5d66-4c41-b56a-b0e2907ba0e7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("34ba3f39-b45b-4145-a4e9-f80c87391bac"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("43697877-eb21-42a8-b4c0-b0b8124a3841"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5db166f5-a56a-4ea3-953d-c602e45ad876"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ef8ce3bb-c3fc-49ab-9ed6-50da2458f6da"));

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
    }
}
