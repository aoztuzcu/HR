using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class entitiesAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayment_Personnels_PersonId",
                table: "AdvancePayment");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequest_Permission_PermissionTypeId",
                table: "PermissionRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequest_Personnels_PersonId",
                table: "PermissionRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionRequest",
                table: "PermissionRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvancePayment",
                table: "AdvancePayment");

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

            migrationBuilder.RenameTable(
                name: "PermissionRequest",
                newName: "PermissionRequests");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "AdvancePayment",
                newName: "AdvancePayments");

            migrationBuilder.RenameIndex(
                name: "IX_PermissionRequest_PersonId",
                table: "PermissionRequests",
                newName: "IX_PermissionRequests_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PermissionRequest_PermissionTypeId",
                table: "PermissionRequests",
                newName: "IX_PermissionRequests_PermissionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancePayment_PersonId",
                table: "AdvancePayments",
                newName: "IX_AdvancePayments_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionRequests",
                table: "PermissionRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvancePayments",
                table: "AdvancePayments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ExpenditureTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenditureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expenditures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyType = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovalStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenditureTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonnelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenditures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenditures_ExpenditureTypes_ExpenditureTypeId",
                        column: x => x.ExpenditureTypeId,
                        principalTable: "ExpenditureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenditures_Personnels_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Expenditures_ExpenditureTypeId",
                table: "Expenditures",
                column: "ExpenditureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenditures_PersonnelId",
                table: "Expenditures",
                column: "PersonnelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonId",
                table: "AdvancePayments",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequests_Permissions_PermissionTypeId",
                table: "PermissionRequests",
                column: "PermissionTypeId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequests_Personnels_PersonId",
                table: "PermissionRequests",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancePayments_Personnels_PersonId",
                table: "AdvancePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequests_Permissions_PermissionTypeId",
                table: "PermissionRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRequests_Personnels_PersonId",
                table: "PermissionRequests");

            migrationBuilder.DropTable(
                name: "Expenditures");

            migrationBuilder.DropTable(
                name: "ExpenditureTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionRequests",
                table: "PermissionRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvancePayments",
                table: "AdvancePayments");

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

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "PermissionRequests",
                newName: "PermissionRequest");

            migrationBuilder.RenameTable(
                name: "AdvancePayments",
                newName: "AdvancePayment");

            migrationBuilder.RenameIndex(
                name: "IX_PermissionRequests_PersonId",
                table: "PermissionRequest",
                newName: "IX_PermissionRequest_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PermissionRequests_PermissionTypeId",
                table: "PermissionRequest",
                newName: "IX_PermissionRequest_PermissionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancePayments_PersonId",
                table: "AdvancePayment",
                newName: "IX_AdvancePayment_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionRequest",
                table: "PermissionRequest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvancePayment",
                table: "AdvancePayment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancePayment_Personnels_PersonId",
                table: "AdvancePayment",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequest_Permission_PermissionTypeId",
                table: "PermissionRequest",
                column: "PermissionTypeId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRequest_Personnels_PersonId",
                table: "PermissionRequest",
                column: "PersonId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
