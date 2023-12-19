using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CompanyEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Personnels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeesCount = table.Column<int>(type: "int", nullable: false),
                    EstablishmentYear = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("0b92c529-f02a-4268-8c30-51142deaa9b3"), "3525fffb-e24f-4c65-8929-8c549358159d", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0125621a-0684-4294-9ebb-c96352a78650"), 0, "e84ce9ed-f65c-4e98-9387-1c50116748e1", "muhammet.coskun@bilgeadamboost.com", true, false, null, "Muhammet", "MUHAMMET.COSKUN@BILGEADAMBOOST.COM", "MUHAMMETCOSKUN", "AQAAAAEAACcQAAAAEFpX702z4uPwdKFI0DgFa5kKmnfBRbX2BL06jpvyPcn7onSbutt2PEuXfVa9Kb1rCA==", null, false, "731a82da-3574-454a-a026-4f5f2120ba74", "Coşkun", false, "muhammetcoskun" },
                    { new Guid("31edbc4e-615b-4057-aed1-268b38e09c10"), 0, "5bfe69fb-f3b5-4303-868d-c6e57c391e91", "mehmetali.mert@bilgeadamboost.com", true, false, null, "Mehmet Ali", "MEHMETALI.MERT@BILGEADAMBOOST.COM", "MEHMETALIMERT", "AQAAAAEAACcQAAAAEEnjd1Js+PUCTdZav6ItTMSHF+1yw/0ZEFhpHiRJrq4TyHwr7bMiRtIFjm4Nxb81lQ==", null, false, "beb33c42-da08-4f62-958e-bd1e42887e51", "Mert", false, "mehmetalimert" },
                    { new Guid("51207994-c920-443d-bf59-4370d511fc64"), 0, "5f89b2d7-69c3-408b-acb8-1b36c09f62e3", "furkan.umman@bilgeadamboost.com", true, false, null, "Furkan", "FURKAN.UMMAN@BILGEADAMBOOST.COM", "FURKANUMMAN", "AQAAAAEAACcQAAAAEB1APZgo7ov/JFpzKEWIzxME5rVmGatdfSfGCFkQ8Gpu+JTiUoSxnm8gVFKlxpWmrA==", null, false, "5652ce4e-000c-4ea2-b1fc-b14106864141", "Umman", false, "furkanumman" },
                    { new Guid("69adb5cd-7e39-48f6-82cf-ee9f8c8ac6c4"), 0, "b1fb925f-b7b9-4029-9201-11c77b8c7962", "abdulkadir.oztuzcu@bilgeadamboost.com", true, false, null, "Abdülkadir", "ABDULKADIR.OZTUZCU@BILGEADAMBOOST.COM", "ABDULKADIROZTUZCU", "AQAAAAEAACcQAAAAEGNAsu9ZHASL1z6GjumtT7iGDz2GL7Ckxjnpu5ohP+tA3Bu26ybzX1wrJz+P2KLvEw==", null, false, "0815049e-a93d-4a49-9318-da774138aacd", "Öztuzcu", false, "abdulkadiroztuzcu" },
                    { new Guid("a8b6c033-5237-4652-9e76-9b4e5ff813ad"), 0, "e8441514-3aa5-4a9a-a2ff-f1d05115cf0a", "betul.demir@bilgeadamboost.com", true, false, null, "Betül", "BETUL.DEMIR@BILGEADAMBOOST.COM", "BETULDEMIR", "AQAAAAEAACcQAAAAEJszPS6H03/0mP3SiIIEHomjSD0LwImpDECcPg7QlJaFeQE5cMmZXOypBJitk3wJbg==", null, false, "b1b0deb8-4d62-4b33-ae89-de6a08512198", "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("09c4266e-a00b-4eca-9867-e06be428c276"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5281), null, true, "İnsan Kaynakları", null },
                    { new Guid("50519ef4-fb44-4bdc-8f5e-3d083fe820d2"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5293), null, true, "Pazarlama", null },
                    { new Guid("7dbce314-58d6-4088-9105-f72be5db5277"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5285), null, true, "Finans", null },
                    { new Guid("7dd1bfdd-3e9e-475d-a26c-934c61a775bb"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5309), null, true, "Bilişim Teknolojileri", null },
                    { new Guid("804159ef-b9ea-4454-94f7-6733818a0a61"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5303), null, true, "Müşteri Hizmetleri", null },
                    { new Guid("91e0036e-04b0-415b-85d8-c39b5459c6e9"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5300), null, true, "Üretim ve Operasyon", null },
                    { new Guid("b337e904-5b62-4ded-aeba-2849b5ee6a6a"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5264), null, true, "AR-GE", null },
                    { new Guid("efeb73d4-0848-4d1f-bd07-09d4aace1606"), null, new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5297), null, true, "Satış", null }
                });

            migrationBuilder.InsertData(
                table: "ExpenditureTypes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "MaxAmount", "MinAmount", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("2a766738-a620-4845-a4de-5e14c2b74d22"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5472), null, true, 5000m, 100m, "Seyahat", null },
                    { new Guid("48311c92-89b2-4821-b66f-41741d8c6b92"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5483), null, true, 1500m, 100m, "Gıda", null },
                    { new Guid("c9daea26-516b-46e0-b22c-6e6d79d47df6"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5487), null, true, 3000m, 50m, "Ulaşım", null },
                    { new Guid("ed6d0b2f-ae17-41be-bc14-8d23540949a2"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5490), null, true, 6000m, 50m, "Sağlık", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("63a7f57b-2f55-4218-bbe3-415ce74f14f7"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5381), null, true, "Endüstri Mühendisi", null },
                    { new Guid("8a298b15-facf-49dc-82ae-685a1d6d942e"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5369), null, true, "FrontEnd Geliştici", null },
                    { new Guid("a10960a8-b3aa-4b81-8eaa-f831608f01ab"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5364), null, true, "Yazılım Mühendisi", null },
                    { new Guid("be64ce52-b9f0-4881-aaf2-5637480f1f43"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5372), null, true, "BackEnd Geliştici", null },
                    { new Guid("ffebe8fc-f063-4acf-a23f-218b8f3c9b50"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5378), null, true, "İnşaat Mühendisi", null }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedDate", "Days", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3cb501df-cd5a-4e1c-9ce8-82a34130a566"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5432), 3f, null, true, "Evlilik İzni", null },
                    { new Guid("7f5be4b4-edf7-425b-861f-b1e8c8262834"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5436), 112f, null, true, "Doğum İzni", null },
                    { new Guid("91001820-e2c6-4161-a452-2183d4c0b727"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5440), 3f, null, true, "Ölüm İzni", null },
                    { new Guid("d127b2d9-edb1-473e-b19b-9621a30ea5d4"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5419), null, null, true, "Yıllık İzin", null },
                    { new Guid("e828a8d7-5d5e-4db2-bff6-089f741f24c3"), new DateTime(2023, 12, 19, 17, 8, 52, 458, DateTimeKind.Local).AddTicks(5426), 5f, null, true, "Babalık İzni", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_CompanyId",
                table: "Personnels",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Company_CompanyId",
                table: "Departments",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Company_CompanyId",
                table: "Personnels",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Company_CompanyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Company_CompanyId",
                table: "Personnels");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_CompanyId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0b92c529-f02a-4268-8c30-51142deaa9b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0125621a-0684-4294-9ebb-c96352a78650"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31edbc4e-615b-4057-aed1-268b38e09c10"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("51207994-c920-443d-bf59-4370d511fc64"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69adb5cd-7e39-48f6-82cf-ee9f8c8ac6c4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a8b6c033-5237-4652-9e76-9b4e5ff813ad"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("09c4266e-a00b-4eca-9867-e06be428c276"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("50519ef4-fb44-4bdc-8f5e-3d083fe820d2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7dbce314-58d6-4088-9105-f72be5db5277"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7dd1bfdd-3e9e-475d-a26c-934c61a775bb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("804159ef-b9ea-4454-94f7-6733818a0a61"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("91e0036e-04b0-415b-85d8-c39b5459c6e9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b337e904-5b62-4ded-aeba-2849b5ee6a6a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("efeb73d4-0848-4d1f-bd07-09d4aace1606"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a766738-a620-4845-a4de-5e14c2b74d22"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("48311c92-89b2-4821-b66f-41741d8c6b92"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("c9daea26-516b-46e0-b22c-6e6d79d47df6"));

            migrationBuilder.DeleteData(
                table: "ExpenditureTypes",
                keyColumn: "Id",
                keyValue: new Guid("ed6d0b2f-ae17-41be-bc14-8d23540949a2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("63a7f57b-2f55-4218-bbe3-415ce74f14f7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8a298b15-facf-49dc-82ae-685a1d6d942e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a10960a8-b3aa-4b81-8eaa-f831608f01ab"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("be64ce52-b9f0-4881-aaf2-5637480f1f43"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ffebe8fc-f063-4acf-a23f-218b8f3c9b50"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3cb501df-cd5a-4e1c-9ce8-82a34130a566"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7f5be4b4-edf7-425b-861f-b1e8c8262834"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("91001820-e2c6-4161-a452-2183d4c0b727"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d127b2d9-edb1-473e-b19b-9621a30ea5d4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e828a8d7-5d5e-4db2-bff6-089f741f24c3"));

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Departments");

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
    }
}
