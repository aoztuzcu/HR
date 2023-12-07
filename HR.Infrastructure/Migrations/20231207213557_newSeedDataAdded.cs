using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newSeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("5825836e-00e2-416f-822f-86136cde710f"), "e3f056b5-d897-4820-919d-7d0bff4921e7", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4fccba9a-496d-4bb0-818b-7bf19cb3e543"), 0, "f7d588fd-db33-4001-825d-c745fdb5921a", "abdulkadir.oztuzcu@bilgeadamboost.com", true, false, null, "Abdülkadir", "ABDULKADIR.OZTUZCU@BILGEADAMBOOST.COM", "ABDULKADIROZTUZCU", "AQAAAAEAACcQAAAAEKnwCQoKlsXGuWSSHC20eir8eDcnQE+eLzhqlLxaa8YbiY4gL6uhqZZUpLvipVZVWA==", null, false, "ce305733-c7e4-4d53-909a-55f6a32f5866", "Öztuzcu", false, "abdulkadiroztuzcu" },
                    { new Guid("5d9dc533-5519-4cf3-b1b2-82260cad1bb4"), 0, "7de3dd85-5ce1-4fde-b3c8-4819a4244ee3", "mehmetali.mert@bilgeadamboost.com", true, false, null, "Mehmet Ali", "MEHMETALI.MERT@BILGEADAMBOOST.COM", "MEHMETALIMERT", "AQAAAAEAACcQAAAAEMPUgTeK8uaMLZZKf0iUGSI5JNx8a889OcjtN2qHG/ja9OqfEwr5Q5nKtsFhKCPjhw==", null, false, "8636a0ae-a6ea-45f1-a375-2392d89dfb3a", "Mert", false, "mehmetalimert" },
                    { new Guid("e09be003-b8c6-4cfa-b25d-8b8979f8e27f"), 0, "c0861097-32c6-4b4c-9ddf-2ed59d135a9a", "muhammet.coskun@bilgeadamboost.com", true, false, null, "Muhammet", "MUHAMMET.COSKUN@BILGEADAMBOOST.COM", "MUHAMMETCOSKUN", "AQAAAAEAACcQAAAAEFvCkR8zNpSD82XYbjmbeyUuy2xK7LpyPtSMcmABQw8yaRo6HTMGOahZ3E4LX7pApw==", null, false, "89304455-0076-4e1f-94f3-89455ea96256", "Coşkun", false, "muhammetcoskun" },
                    { new Guid("ea726d61-b84b-403a-b43b-b7cf18a1a34e"), 0, "a33c4945-557c-4fb5-8eec-d551a8893335", "betul.demir@bilgeadamboost.com", true, false, null, "Betül", "BETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEFqrZUgRI4UXEjP3oc+cwNqTss0ZiWuySpDApVOTNNrE6R3p+tfzG+1TrR+/6ds1qw==", null, false, "e320242e-17d8-4170-8c4a-a8e7b5dd0e5a", "Demir", false, "betuldemir" },
                    { new Guid("f2e6e6e1-979a-4a05-8422-12665cb4eba5"), 0, "87066479-4322-46ff-bbb9-29e9450b4cdb", "furkan.umman@bilgeadamboost.com", true, false, null, "Furkan", "FURKAN.UMMAN@BILGEADAMBOOST.COM", "FURKANUMMAN", "AQAAAAEAACcQAAAAEACgdguXF3Mi2uRe1V3j6ztscwC6jW2sUKHwa+qgflW/cgEFLxDuNOS9I0+s+O8v/A==", null, false, "3bc4ecfe-5923-4db8-a461-233fe9fdb2f2", "Umman", false, "furkanumman" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("387a5419-0f4f-4be4-9f93-d86d3e43a61b"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1287), null, true, "Finans", null },
                    { new Guid("4c83e14f-cea4-4d7f-82e4-d9d925e705d7"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1299), null, true, "Müşteri Hizmetleri", null },
                    { new Guid("6bfa0e4c-469a-4ae0-815c-14c2e90991e8"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1301), null, true, "Bilişim Teknolojileri", null },
                    { new Guid("7761c3a6-2c96-4f0b-ae42-f2d6bb2510ec"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1285), null, true, "İnsan Kaynakları", null },
                    { new Guid("a674174f-67d4-46ec-b583-60ba2348c36d"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1290), null, true, "Pazarlama", null },
                    { new Guid("a6c0f5b4-bde3-424e-8617-05a4a09c2ded"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1297), null, true, "Üretim ve Operasyon", null },
                    { new Guid("cf49e202-9783-4641-961b-f2cc2102f992"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1261), null, true, "AR-GE", null },
                    { new Guid("ff6ad11f-6705-41e8-9af7-b9cc51f08997"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1292), null, true, "Satış", null }
                });

            migrationBuilder.InsertData(
                table: "ExpenditureTypes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "MaxAmount", "MinAmount", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d064fe6-b715-4997-a602-c8a7baebe743"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1459), null, true, 6000m, 50m, "Sağlık", null },
                    { new Guid("3e81a881-eb16-4bb8-8d34-a52ace034d2b"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1445), null, true, 5000m, 100m, "Seyahat", null },
                    { new Guid("ab583ab5-b234-4bfb-88bf-50776f2921f4"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1454), null, true, 3000m, 50m, "Ulaşım", null },
                    { new Guid("d1243c44-8410-4dab-9cba-902fee5d80f8"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1451), null, true, 1500m, 100m, "Gıda", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1a724d72-f2aa-45c8-b22d-ce3e9f871dd8"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1367), null, true, "BackEnd Geliştici", null },
                    { new Guid("34301f2e-1dd3-422d-8946-11fdfd6ac58f"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1358), null, true, "Yazılım Mühendisi", null },
                    { new Guid("3b184833-8c3d-4f97-a46c-fa326249ba68"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1369), null, true, "İnşaat Mühendisi", null },
                    { new Guid("9edb4bc0-969d-49f9-a752-0c14576ab74c"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1372), null, true, "Endüstri Mühendisi", null },
                    { new Guid("9ee5616a-c13d-4d99-8953-178058e93536"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1364), null, true, "FrontEnd Geliştici", null }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedDate", "Days", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("35040a1a-4e5f-438e-8eba-af2e82dfd1ae"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1417), 112f, null, true, "Doğum İzni", null },
                    { new Guid("4b7018c2-a031-4da5-a32b-010169e4bc1b"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1414), 3f, null, true, "Evlilik İzni", null },
                    { new Guid("6262bbcc-c007-4a95-8194-d70d8477a25b"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1422), 3f, null, true, "Ölüm İzni", null },
                    { new Guid("8ba143ca-5ef7-42bd-b4b5-0c419903f48d"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1411), 5f, null, true, "Babalık İzni", null },
                    { new Guid("ed03ba1f-253c-4d8a-b8d5-26c4268c1484"), new DateTime(2023, 12, 8, 0, 35, 57, 220, DateTimeKind.Local).AddTicks(1407), null, null, true, "Yıllık İzin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5825836e-00e2-416f-822f-86136cde710f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4fccba9a-496d-4bb0-818b-7bf19cb3e543"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d9dc533-5519-4cf3-b1b2-82260cad1bb4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e09be003-b8c6-4cfa-b25d-8b8979f8e27f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ea726d61-b84b-403a-b43b-b7cf18a1a34e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2e6e6e1-979a-4a05-8422-12665cb4eba5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("387a5419-0f4f-4be4-9f93-d86d3e43a61b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4c83e14f-cea4-4d7f-82e4-d9d925e705d7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6bfa0e4c-469a-4ae0-815c-14c2e90991e8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7761c3a6-2c96-4f0b-ae42-f2d6bb2510ec"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a674174f-67d4-46ec-b583-60ba2348c36d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a6c0f5b4-bde3-424e-8617-05a4a09c2ded"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cf49e202-9783-4641-961b-f2cc2102f992"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ff6ad11f-6705-41e8-9af7-b9cc51f08997"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("1d064fe6-b715-4997-a602-c8a7baebe743"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e81a881-eb16-4bb8-8d34-a52ace034d2b"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("ab583ab5-b234-4bfb-88bf-50776f2921f4"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("d1243c44-8410-4dab-9cba-902fee5d80f8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1a724d72-f2aa-45c8-b22d-ce3e9f871dd8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("34301f2e-1dd3-422d-8946-11fdfd6ac58f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3b184833-8c3d-4f97-a46c-fa326249ba68"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9edb4bc0-969d-49f9-a752-0c14576ab74c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9ee5616a-c13d-4d99-8953-178058e93536"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35040a1a-4e5f-438e-8eba-af2e82dfd1ae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4b7018c2-a031-4da5-a32b-010169e4bc1b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6262bbcc-c007-4a95-8194-d70d8477a25b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8ba143ca-5ef7-42bd-b4b5-0c419903f48d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed03ba1f-253c-4d8a-b8d5-26c4268c1484"));

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
    }
}
