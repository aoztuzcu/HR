using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editAdvance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("995fef93-14e5-4756-8c39-02df08cf521d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("37f0f8da-36ec-437a-8874-eb6316894499"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("48774d53-0601-42e1-96bc-e483f3e0d1e0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("61c2a9d4-af28-4a8d-a62a-084a2f1f5c8f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("adc181cf-6a06-42df-ad7c-775df2aee02a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("173fbda3-6a26-4125-8602-65046f578d24"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3f8ba16c-f1b5-4cd1-ad0d-fa83b64837f3"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7d371903-4494-40b7-a8e1-deaf03458236"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("be5962f8-bbbb-4db3-b3ea-cf5622725c1c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d6079285-7f53-4d45-a037-10b1629a1dd8"));

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

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"),
                columns: new[] { "DepartmentId", "HireDate", "JobId" },
                values: new object[] { new Guid("fcbf38c4-d4a0-46cf-a876-9a11fd697d22"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9454), new Guid("58987f9e-384e-4726-bcdb-00c22481ff93") });

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"),
                columns: new[] { "DepartmentId", "HireDate", "JobId" },
                values: new object[] { new Guid("e03a2119-1b45-4817-9fa4-7fc27b110179"), new DateTime(2023, 12, 4, 13, 3, 42, 330, DateTimeKind.Local).AddTicks(9471), new Guid("4b64b4b1-b9d8-4e00-b8f5-e19a9ed24522") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("e03a2119-1b45-4817-9fa4-7fc27b110179"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f8c86705-b6b7-4f68-8522-2c48db2c981f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("fcbf38c4-d4a0-46cf-a876-9a11fd697d22"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("065a8b47-43a5-4984-b979-d434a92fa89f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b64b4b1-b9d8-4e00-b8f5-e19a9ed24522"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("58987f9e-384e-4726-bcdb-00c22481ff93"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5e01f709-53ae-4f32-96b0-aa9a1789f066"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("9dbfb1cf-bf3f-4a3d-affd-230f3cebb087"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("995fef93-14e5-4756-8c39-02df08cf521d"), "a94fd863-0a48-40e4-a4a9-b680a3f7656b", "Personnel", "PERSONNEL" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("37f0f8da-36ec-437a-8874-eb6316894499"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8777), null, true, "İnsan Kaynakları", null },
                    { new Guid("48774d53-0601-42e1-96bc-e483f3e0d1e0"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8765), null, true, "Mekanik Tasarım", null },
                    { new Guid("61c2a9d4-af28-4a8d-a62a-084a2f1f5c8f"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8781), null, true, "Bilişim Teknolojileri", null },
                    { new Guid("adc181cf-6a06-42df-ad7c-775df2aee02a"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8779), null, true, "Muhasebe", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("173fbda3-6a26-4125-8602-65046f578d24"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8968), null, true, "FrontEnd Geliştici", null },
                    { new Guid("3f8ba16c-f1b5-4cd1-ad0d-fa83b64837f3"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8972), null, true, "İnşaat Mühendisi", null },
                    { new Guid("7d371903-4494-40b7-a8e1-deaf03458236"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8975), null, true, "Endüstri Mühendisi", null },
                    { new Guid("be5962f8-bbbb-4db3-b3ea-cf5622725c1c"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8971), null, true, "BackEnd Geliştici", null },
                    { new Guid("d6079285-7f53-4d45-a037-10b1629a1dd8"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(8961), null, true, "Yazılım Mühendisi", null }
                });

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"),
                columns: new[] { "DepartmentId", "HireDate", "JobId" },
                values: new object[] { new Guid("61c2a9d4-af28-4a8d-a62a-084a2f1f5c8f"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(9052), new Guid("d6079285-7f53-4d45-a037-10b1629a1dd8") });

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"),
                columns: new[] { "DepartmentId", "HireDate", "JobId" },
                values: new object[] { new Guid("48774d53-0601-42e1-96bc-e483f3e0d1e0"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(9065), new Guid("3f8ba16c-f1b5-4cd1-ad0d-fa83b64837f3") });
        }
    }
}
