using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Order_Ship_Information_Column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "f2d09ae7-f8e7-4009-a98e-aaf648aeda98");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "03e5c71b-fed0-4d75-a742-add9a17a7e48", "AQAAAAEAACcQAAAAEOzk187Z59k+bg+lV4Pu7L0S7sDdeW+PYBEfpwKVGpJPh4tHFJYTy4dwedpUzWrXnA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 141, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 142, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 142, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 142, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 142, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 34, 9, 142, DateTimeKind.Local).AddTicks(6460));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "2c144f63-b4ec-4684-9295-630a3e2eae9a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8b5398e-3b12-4b2d-8fe6-f8ec24795fb7", "AQAAAAEAACcQAAAAEJckdD3FwJ2zKNlENcijqpqRnwoeVhqV2hEzJx+MNIkVxpWOIIbNiQW4eBxxWZRwJg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 750, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 751, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 751, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 751, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 751, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 32, 46, 751, DateTimeKind.Local).AddTicks(2379));
        }
    }
}
