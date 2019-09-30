using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterApp.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAccountCreated",
                value: new DateTime(2019, 9, 30, 10, 38, 51, 832, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAccountCreated",
                value: new DateTime(2019, 9, 30, 10, 38, 51, 834, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAccountCreated",
                value: new DateTime(2019, 9, 30, 10, 29, 3, 138, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAccountCreated",
                value: new DateTime(2019, 9, 30, 10, 29, 3, 141, DateTimeKind.Local));
        }
    }
}
