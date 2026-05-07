using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymQuest.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Routines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Routines",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 13, 1, 52, 165, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 13, 1, 52, 165, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 13, 1, 52, 165, DateTimeKind.Utc).AddTicks(4525));
        }
    }
}
