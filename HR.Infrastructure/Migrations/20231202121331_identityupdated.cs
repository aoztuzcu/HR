using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class identityupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d8b46b8-4420-41e8-b857-d44a27914c1b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3b877af-050d-4823-87dc-06b54eaabed3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("14b93bc2-7629-4d9d-abc6-4614d93ca03b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cbe82207-3ef2-4a38-831e-64cdcf94abf6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("29f64270-2f72-48ea-8753-ca342284aebd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("451e1d77-8668-49c7-a438-b842f0c1eacb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("bdf84c5a-e3e4-4cfe-8c9a-3afcdccf072f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("19d5e2a3-c627-4827-b664-65210694f854"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("e847c120-1dc9-4bff-844a-55260832ef22"));

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("51d793e9-20d2-458d-818e-1f560ec06e5a"), "aeb80a9b-613d-41c0-98f0-6fdb23bf55e1", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f2b5c88-f991-4349-89fe-f1c20d50f3c6"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3212), null, true, "Information Technology", null },
                    { new Guid("3a5425c2-32bb-45ae-85aa-4edaf2de3c56"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3205), null, true, "HR", null },
                    { new Guid("b96a3392-6888-452d-95c5-30d752ededaf"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3209), null, true, "Accounting", null },
                    { new Guid("e082b6f9-2f30-40a8-bdd8-0b56c839e7ac"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3189), null, true, "Mechanical Design", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("7da4775d-dbea-42ba-bb2e-41581a61cca8"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3496), null, true, "Software Developer", null },
                    { new Guid("8c1a23a1-9626-4ee7-8e03-7b32375a77de"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3504), null, true, "BackEnd Developer", null },
                    { new Guid("932963e1-848d-4320-87f1-65f7b21c8201"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3501), null, true, "FrontEnd Developer", null },
                    { new Guid("b16a9bdd-01ba-492a-8284-a0574dc3ed82"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3512), null, true, "Industrial Engineer", null },
                    { new Guid("cfe8c08a-5148-40f7-b60f-ed8a92f39f6e"), new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(3508), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0167cfa1-c674-45f6-9c49-3143715cfc4c"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "87ced044-b40b-4dc7-b566-08771a8e593e", new Guid("0f2b5c88-f991-4349-89fe-f1c20d50f3c6"), null, false, null, (byte)1, new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(4456), "65803196176", new Guid("7da4775d-dbea-42ba-bb2e-41581a61cca8"), false, null, "Elif", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, "betuldemir" },
                    { new Guid("d61fccfe-f767-42a4-944a-46f408e10d3b"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "6d53f8f2-76a3-479a-907c-b87008d5eb1e", new Guid("e082b6f9-2f30-40a8-bdd8-0b56c839e7ac"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 15, 13, 30, 717, DateTimeKind.Local).AddTicks(4478), "58963214568", new Guid("cfe8c08a-5148-40f7-b60f-ed8a92f39f6e"), false, null, "Muhammet", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, "muhammetcoskun" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("51d793e9-20d2-458d-818e-1f560ec06e5a"), new Guid("d61fccfe-f767-42a4-944a-46f408e10d3b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("51d793e9-20d2-458d-818e-1f560ec06e5a"), new Guid("d61fccfe-f767-42a4-944a-46f408e10d3b") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0167cfa1-c674-45f6-9c49-3143715cfc4c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3a5425c2-32bb-45ae-85aa-4edaf2de3c56"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b96a3392-6888-452d-95c5-30d752ededaf"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("8c1a23a1-9626-4ee7-8e03-7b32375a77de"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("932963e1-848d-4320-87f1-65f7b21c8201"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("b16a9bdd-01ba-492a-8284-a0574dc3ed82"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("51d793e9-20d2-458d-818e-1f560ec06e5a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d61fccfe-f767-42a4-944a-46f408e10d3b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0f2b5c88-f991-4349-89fe-f1c20d50f3c6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7da4775d-dbea-42ba-bb2e-41581a61cca8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e082b6f9-2f30-40a8-bdd8-0b56c839e7ac"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("cfe8c08a-5148-40f7-b60f-ed8a92f39f6e"));

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "AspNetUsers",
                type: "varchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("14b93bc2-7629-4d9d-abc6-4614d93ca03b"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8746), null, true, "HR", null },
                    { new Guid("19d5e2a3-c627-4827-b664-65210694f854"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8720), null, true, "Mechanical Design", null },
                    { new Guid("cbe82207-3ef2-4a38-831e-64cdcf94abf6"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8749), null, true, "Accounting", null },
                    { new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8751), null, true, "Information Technology", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("29f64270-2f72-48ea-8753-ca342284aebd"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8903), null, true, "Industrial Engineer", null },
                    { new Guid("451e1d77-8668-49c7-a438-b842f0c1eacb"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8899), null, true, "BackEnd Developer", null },
                    { new Guid("bdf84c5a-e3e4-4cfe-8c9a-3afcdccf072f"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8893), null, true, "FrontEnd Developer", null },
                    { new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8889), null, true, "Software Developer", null },
                    { new Guid("e847c120-1dc9-4bff-844a-55260832ef22"), new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8901), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Mail", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6d8b46b8-4420-41e8-b857-d44a27914c1b"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "29c5533c-4c5c-4e88-9f16-d2a415f8124c", new Guid("19d5e2a3-c627-4827-b664-65210694f854"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8996), "58963214568", new Guid("e847c120-1dc9-4bff-844a-55260832ef22"), false, null, null, "Muhammet", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, null },
                    { new Guid("c3b877af-050d-4823-87dc-06b54eaabed3"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "cfbf58cf-0b8e-41fb-aa9d-6f9d2ff7c0eb", new Guid("eb9e5351-0c3a-4bd2-b5bd-a4ecf2cb6509"), null, false, null, (byte)1, new DateTime(2023, 12, 2, 14, 53, 56, 810, DateTimeKind.Local).AddTicks(8982), "65803196176", new Guid("d6d87fd7-4642-4949-a1e8-7e3b1a234bd4"), false, null, null, "Elif", null, null, null, "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, null }
                });
        }
    }
}
