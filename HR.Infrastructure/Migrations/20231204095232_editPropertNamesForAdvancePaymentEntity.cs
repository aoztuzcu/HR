using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editPropertNamesForAdvancePaymentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonId",
                table: "AdvancePayments");

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
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936"));

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "AdvancePayments",
                newName: "PersonnelId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancePayments_PersonId",
                table: "AdvancePayments",
                newName: "IX_AdvancePayments_PersonnelId");

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
                columns: new[] { "DepartmentId", "HireDate", "IdentityNumber", "JobId" },
                values: new object[] { new Guid("61c2a9d4-af28-4a8d-a62a-084a2f1f5c8f"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(9052), "66047609514", new Guid("d6079285-7f53-4d45-a037-10b1629a1dd8") });

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"),
                columns: new[] { "BirthDate", "DepartmentId", "HireDate", "IdentityNumber", "JobId" },
                values: new object[] { new DateTime(2000, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48774d53-0601-42e1-96bc-e483f3e0d1e0"), new DateTime(2023, 12, 4, 12, 52, 32, 472, DateTimeKind.Local).AddTicks(9065), "56555011244", new Guid("3f8ba16c-f1b5-4cd1-ad0d-fa83b64837f3") });

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonnelId",
                table: "AdvancePayments",
                column: "PersonnelId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonnelId",
                table: "AdvancePayments");

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

            migrationBuilder.RenameColumn(
                name: "PersonnelId",
                table: "AdvancePayments",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancePayments_PersonnelId",
                table: "AdvancePayments",
                newName: "IX_AdvancePayments_PersonId");

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

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("03c01409-dc14-4bbd-bd72-f895a53bb66c"),
                columns: new[] { "DepartmentId", "HireDate", "IdentityNumber", "JobId" },
                values: new object[] { new Guid("95c58c81-13db-45da-9371-efd138dd6d8f"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4177), "65803196176", new Guid("94f615ea-32f5-4e7d-84bb-4cec01f11af6") });

            migrationBuilder.UpdateData(
                table: "Personnels",
                keyColumn: "Id",
                keyValue: new Guid("e0fbe2ba-8712-4c03-91df-172e2f76e23c"),
                columns: new[] { "BirthDate", "DepartmentId", "HireDate", "IdentityNumber", "JobId" },
                values: new object[] { new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("93b7f4e3-01ab-4609-8c95-7b6ed9e861ea"), new DateTime(2023, 12, 4, 10, 31, 28, 322, DateTimeKind.Local).AddTicks(4185), "58963214568", new Guid("d8c5a8f2-4e33-4094-ae00-325d33f93936") });

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonId",
                table: "AdvancePayments",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
