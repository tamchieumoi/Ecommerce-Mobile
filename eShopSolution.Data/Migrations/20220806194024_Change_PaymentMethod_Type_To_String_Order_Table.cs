using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Change_PaymentMethod_Type_To_String_Order_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "fd998bae-3c15-4b79-9243-78bc86626450");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "656b3ea8-0664-4692-91d1-183c23fc909d", "AQAAAAEAACcQAAAAEDs8Ggy8LEMW8P9JEmnLCxxUnBGZ+QDWwTJdp2BXWtKROJ+7xfeSeVcBXmzJBhOBSA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 966, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 974, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 974, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 974, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 974, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 45, 974, DateTimeKind.Local).AddTicks(8192));
        }
    }
}
