using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Add_PaymentMethod_Column_To_Order_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "c2b47d21-ed8e-4310-96de-3109832589c6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61616128-5c2f-4cb4-a5ad-e0a3df1fa897", "AQAAAAEAACcQAAAAEHGmvMI8SF/3M1YyxAu29ZM/Jzx8OOAvVkGtuPbdhljuAagC5cX7UCrLnSsvTc9CRw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 577, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 578, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 578, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 578, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 578, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 36, 46, 578, DateTimeKind.Local).AddTicks(3421));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7566587d-0e8f-4a36-bc05-69f33ff55c23"),
                column: "ConcurrencyStamp",
                value: "f729b563-12a1-40fe-8181-b5fc3cc3c80f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("fb819bc6-2b1c-40c9-ac25-896df1ecefdf"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de79d722-2ae1-486c-ba1f-c4458303d1ec", "AQAAAAEAACcQAAAAENlM5i/GyzSwHUifJpd0+DSzpekadSt90UquoM/afWK5EgoIecoPY5irI0yp9JWzoQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 372, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 373, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 373, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 373, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 373, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 8, 7, 2, 35, 20, 373, DateTimeKind.Local).AddTicks(4027));
        }
    }
}
