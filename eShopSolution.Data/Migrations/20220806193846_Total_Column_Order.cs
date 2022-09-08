using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Total_Column_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "b6a90b3b-f73c-413e-9dc6-1f114bbdb0c6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2f6f4008-9701-4539-96cc-82def3a0e5e3", "AQAAAAEAACcQAAAAEGzrp5vUeUvAi6QlKhh6RFmxpRKZ8608bdhSu94wmjOyCGqZmg45WZ0IcUfbq9XjUg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 38, 0, 470, DateTimeKind.Local).AddTicks(8185));
        }
    }
}
