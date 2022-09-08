using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddNewRole_AppRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "a4d3fbf7-fde5-4e2b-bcec-45c795254bf0");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("bf9b2cab-d403-4b08-8d6a-868c59d8a3e5"), "68f0ca9a-2931-4d94-b43f-429b4f3da32d", "User role", "user", "user" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e9b70ce-514b-4787-974a-d29371cf012e", "AQAAAAEAACcQAAAAEBDXilMXFB0rdWAH3+NuzY2FNCokSl5zxBq58TSjpg6otbCgrLdD7v7hYAljhdoorA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 9, 1, 5, 30, 16, 571, DateTimeKind.Local).AddTicks(8274));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bf9b2cab-d403-4b08-8d6a-868c59d8a3e5"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "9bb0c760-af74-4c5c-8a2b-2ea80eb4cbbc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8029b139-d495-4274-9e50-b29b7f82ae93", "AQAAAAEAACcQAAAAEAW3eQ4R3zgMbKdVb1/uNsr0Kvbigs9Ku1I06AQ1jMx0RX9RMiw2tabYMpg5Evjwog==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 423, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 424, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 424, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 424, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 424, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 40, 24, 424, DateTimeKind.Local).AddTicks(4813));
        }
    }
}