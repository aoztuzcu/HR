using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editAdvance2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("06edd8f4-cb1b-4f04-9f66-d6fe55f63318"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("36776b4e-a03d-4cc0-9f38-cc653247abb9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f8c86705-b6b7-4f68-8522-2c48db2c981f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("065a8b47-43a5-4984-b979-d434a92fa89f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5e01f709-53ae-4f32-96b0-aa9a1789f066"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9dbfb1cf-bf3f-4a3d-affd-230f3cebb087"));

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
                keyValue: new Guid("e03a2119-1b45-4817-9fa4-7fc27b110179"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fcbf38c4-d4a0-46cf-a876-9a11fd697d22"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b64b4b1-b9d8-4e00-b8f5-e19a9ed24522"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("58987f9e-384e-4726-bcdb-00c22481ff93"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("25129f2f-a329-4f55-bd32-208deab56b88"), "5bf2b7b9-507c-44ef-a437-f1e23f5dee14", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("32869ac2-c371-4109-b25a-88868eb64b26"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9148), null, true, "İnsan Kaynakları", null },
                    { new Guid("7f6e8795-0bcf-4dc5-b6bc-cddbf7132b87"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9151), null, true, "Muhasebe", null },
                    { new Guid("c8e6d47e-1f77-4f06-8d65-ce6bd2aac20e"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9134), null, true, "Mekanik Tasarım", null },
                    { new Guid("e4c59894-6f74-4c37-847d-c23294018a55"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9152), null, true, "Bilişim Teknolojileri", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("52e265ec-264d-4e78-8743-d911db132873"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9357), null, true, "Yazılım Mühendisi", null },
                    { new Guid("66f9aa21-8c13-4350-b985-28e199b07219"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9370), null, true, "BackEnd Geliştici", null },
                    { new Guid("6829ee7f-0486-4b71-8e96-4f4743f7ec7b"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9372), null, true, "İnşaat Mühendisi", null },
                    { new Guid("d8463e96-8918-45d9-9203-91198d70cad5"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9367), null, true, "FrontEnd Geliştici", null },
                    { new Guid("ee4119ff-5e2d-4ccc-80f0-21cb21e29adf"), new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9374), null, true, "Endüstri Mühendisi", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "Email", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("33ccc344-64c0-4667-a5a0-e0b49031887b"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("e4c59894-6f74-4c37-847d-c23294018a55"), "betul.demir@bilgeadamboost.com", null, (byte)1, new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9441), "66047609514", true, new Guid("52e265ec-264d-4e78-8743-d911db132873"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("911a1c08-5f37-4d89-a73c-568b044c0818"), "Yenibosna/İstanbul", null, new DateTime(2000, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c8e6d47e-1f77-4f06-8d65-ce6bd2aac20e"), "muhammet.coskun@bilgeadamboost.com", null, (byte)0, new DateTime(2023, 12, 4, 13, 7, 39, 317, DateTimeKind.Local).AddTicks(9458), "56555011244", true, new Guid("6829ee7f-0486-4b71-8e96-4f4743f7ec7b"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("25129f2f-a329-4f55-bd32-208deab56b88"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("32869ac2-c371-4109-b25a-88868eb64b26"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7f6e8795-0bcf-4dc5-b6bc-cddbf7132b87"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("66f9aa21-8c13-4350-b985-28e199b07219"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d8463e96-8918-45d9-9203-91198d70cad5"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ee4119ff-5e2d-4ccc-80f0-21cb21e29adf"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("33ccc344-64c0-4667-a5a0-e0b49031887b"));

            migrationBuilder.DeleteData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("911a1c08-5f37-4d89-a73c-568b044c0818"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c8e6d47e-1f77-4f06-8d65-ce6bd2aac20e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e4c59894-6f74-4c37-847d-c23294018a55"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("52e265ec-264d-4e78-8743-d911db132873"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6829ee7f-0486-4b71-8e96-4f4743f7ec7b"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("06edd8f4-cb1b-4f04-9f66-d6fe55f63318"), "48a145f7-68b2-4e70-8a40-0e2e7d7d3f09", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("36776b4e-a03d-4cc0-9f38-cc653247abb9"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9095), null, true, "İnsan Kaynakları", null },
                    { new Guid("e03a2119-1b45-4817-9fa4-7fc27b110179"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9078), null, true, "Mekanik Tasarım", null },
                    { new Guid("f8c86705-b6b7-4f68-8522-2c48db2c981f"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9098), null, true, "Muhasebe", null },
                    { new Guid("fcbf38c4-d4a0-46cf-a876-9a11fd697d22"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9100), null, true, "Bilişim Teknolojileri", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("065a8b47-43a5-4984-b979-d434a92fa89f"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9368), null, true, "Endüstri Mühendisi", null },
                    { new Guid("4b64b4b1-b9d8-4e00-b8f5-e19a9ed24522"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9366), null, true, "İnşaat Mühendisi", null },
                    { new Guid("58987f9e-384e-4726-bcdb-00c22481ff93"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9353), null, true, "Yazılım Mühendisi", null },
                    { new Guid("5e01f709-53ae-4f32-96b0-aa9a1789f066"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9364), null, true, "BackEnd Geliştici", null },
                    { new Guid("9dbfb1cf-bf3f-4a3d-affd-230f3cebb087"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9361), null, true, "FrontEnd Geliştici", null }
                });

            migrationBuilder.InsertData(
                table: "Personnels",
                columns: new[] { "Id", "Address", "AnnualPermissionDays", "BirthDate", "CompanyName", "CreatedDate", "DeletedDate", "DepartmentId", "Email", "FireDate", "Gender", "HireDate", "IdentityNumber", "IsActive", "JobId", "Name", "PhoneNumber", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "Surname", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"), "Kadıköy/İstanbul", null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fcbf38c4-d4a0-46cf-a876-9a11fd697d22"), "betul.demir@bilgeadamboost.com", null, (byte)1, new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9454), "66047609514", true, new Guid("58987f9e-384e-4726-bcdb-00c22481ff93"), "Elif", "5226932145", "image_avatar-female.png", "İstanbul", 34000, "Betül", null, "Demir", null },
                    { new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"), "Yenibosna/İstanbul", null, new DateTime(2000, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("e03a2119-1b45-4817-9fa4-7fc27b110179"), "muhammet.coskun@bilgeadamboost.com", null, (byte)0, new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9471), "56555011244", true, new Guid("4b64b4b1-b9d8-4e00-b8f5-e19a9ed24522"), "Muhammet", "5226932145", "image_avatar-female.png", "İstanbul", 34000, null, null, "Coşkun", null }
                });
        }
    }
}
