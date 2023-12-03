using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class identityusername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), "739fe878-870d-4daf-b030-af8a3cfe1752", "Personnel", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1022a8d1-493f-4e45-8343-426d1c9ced0c"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9696), null, true, "Accounting", null },
                    { new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9698), null, true, "Information Technology", null },
                    { new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9670), null, true, "Mechanical Design", null },
                    { new Guid("f230ea80-2ecc-46db-ae41-680948e854dd"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9686), null, true, "HR", null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("05cd27e7-f17d-4ca6-86e9-23fc1d5722a1"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9940), null, true, "FrontEnd Developer", null },
                    { new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9935), null, true, "Software Developer", null },
                    { new Guid("cc8fcab2-f7c0-41ed-9110-997aaaf2c5be"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9955), null, true, "Industrial Engineer", null },
                    { new Guid("ecf58c4a-cc11-465d-8042-861fd8db85ff"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9943), null, true, "BackEnd Developer", null },
                    { new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"), new DateTime(2023, 12, 2, 15, 18, 23, 871, DateTimeKind.Local).AddTicks(9946), null, true, "Civil Engineer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "AnnualPermissionDays", "AnnualTakeAdvanceAmount", "BirthDate", "CompanyName", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FireDate", "Gender", "HireDate", "IdentityNumber", "JobId", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Photo", "PlaceofBirth", "Salary", "SecondName", "SecondSurname", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb"), 0, "Yenibosna/İstanbul", null, null, new DateTime(2000, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Microsoft", "4c30db44-6a2a-4b10-a73f-bfa862e89ffa", new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"), null, false, null, (byte)0, new DateTime(2023, 12, 2, 15, 18, 23, 885, DateTimeKind.Local).AddTicks(4031), "58963214568", new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"), false, null, "Muhammet", null, null, "AQAAAAEAACcQAAAAEPDobBDXvslRT/Q4ldkMz0NpxB3xC2JGdC/LncyzAPMEgCWVU2XgGFeuyDcNCopnFg==", "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, null, null, null, "Coşkun", false, "muhammetcoskun" },
                    { new Guid("e6eda59d-c41f-40c7-98e2-a77f7e5de27d"), 0, "Kadıköy/İstanbul", null, null, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Google", "b7b30bc4-8a06-47ac-af99-d08ca9182f4f", new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"), null, false, null, (byte)1, new DateTime(2023, 12, 2, 15, 18, 23, 872, DateTimeKind.Local).AddTicks(81), "65803196176", new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"), false, null, "Elif", null, null, "AQAAAAEAACcQAAAAEFYczEkibHVzbRnDLeKVevv9UNqK8MT568BN05VK+ulob5WEBL5I2WXrR4oRWDKGzA==", "5226932145", false, "image_avatar-female.png", "İstanbul", 34000, "Betül", null, null, "Demir", false, "betuldemir" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"), new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6eda59d-c41f-40c7-98e2-a77f7e5de27d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1022a8d1-493f-4e45-8343-426d1c9ced0c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f230ea80-2ecc-46db-ae41-680948e854dd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("05cd27e7-f17d-4ca6-86e9-23fc1d5722a1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("cc8fcab2-f7c0-41ed-9110-997aaaf2c5be"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ecf58c4a-cc11-465d-8042-861fd8db85ff"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("58a9985c-d04c-44d2-8853-e6c5c8e99930"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6b7ef09-b210-4c45-808b-0b4ed8c672bb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4e44f99a-8199-42c5-8c41-da7668410ba1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("7df113aa-d2bc-431c-a548-2b01e2747b2a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9013683a-3ccc-4c86-9077-2cbdd019532c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("ef4d1260-4504-4f7a-b499-72c311ab38b0"));

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
    }
}
