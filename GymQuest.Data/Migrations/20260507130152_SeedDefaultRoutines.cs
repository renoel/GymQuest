using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymQuest.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultRoutines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineSet_RoutinesExercises_RoutineExerciseId",
                table: "RoutineSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineSet",
                table: "RoutineSet");

            migrationBuilder.RenameTable(
                name: "RoutineSet",
                newName: "RoutineSets");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineSet_RoutineExerciseId",
                table: "RoutineSets",
                newName: "IX_RoutineSets_RoutineExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineSets",
                table: "RoutineSets",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineSets_RoutinesExercises_RoutineExerciseId",
                table: "RoutineSets",
                column: "RoutineExerciseId",
                principalTable: "RoutinesExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineSets_RoutinesExercises_RoutineExerciseId",
                table: "RoutineSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineSets",
                table: "RoutineSets");

            migrationBuilder.RenameTable(
                name: "RoutineSets",
                newName: "RoutineSet");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineSets_RoutineExerciseId",
                table: "RoutineSet",
                newName: "IX_RoutineSet_RoutineExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineSet",
                table: "RoutineSet",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineSet_RoutinesExercises_RoutineExerciseId",
                table: "RoutineSet",
                column: "RoutineExerciseId",
                principalTable: "RoutinesExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
