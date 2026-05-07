using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymQuest.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "BaseXP", "Category", "MuscleGroup", "Name" },
                values: new object[,]
                {
                    { 1, 35, "Strength", "Chest", "Bench Press" },
                    { 2, 30, "Strength", "Shoulders", "Shoulder Press" },
                    { 3, 20, "Isolation", "Arms", "Tricep Pushdown" },
                    { 4, 40, "Bodyweight", "Back", "Pull Up" },
                    { 5, 35, "Strength", "Back", "Barbell Row" },
                    { 6, 20, "Isolation", "Arms", "Bicep Curl" },
                    { 7, 45, "Strength", "Legs", "Squat" },
                    { 8, 35, "Machine", "Legs", "Leg Press" },
                    { 9, 20, "Isolation", "Legs", "Leg Curl" }
                });

            migrationBuilder.InsertData(
                table: "Routines",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDefault", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(8682), "Chest, shoulders and triceps", true, "Push" },
                    { 2, new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(9639), "Back and biceps", true, "Pull" },
                    { 3, new DateTime(2026, 5, 7, 12, 59, 16, 233, DateTimeKind.Utc).AddTicks(9641), "Heavy leg workout", true, "Legs" }
                });

            migrationBuilder.InsertData(
                table: "RoutinesExercises",
                columns: new[] { "Id", "ExerciseId", "OrderIndex", "RoutineId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 1 },
                    { 3, 3, 3, 1 },
                    { 4, 4, 1, 2 },
                    { 5, 5, 2, 2 },
                    { 6, 6, 3, 2 },
                    { 7, 7, 1, 3 },
                    { 8, 8, 2, 3 },
                    { 9, 9, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoutineSet",
                columns: new[] { "Id", "RestSeconds", "RoutineExerciseId", "SetNumber", "TargetReps", "TargetWeight" },
                values: new object[,]
                {
                    { 1, 90, 1, 1, 8, 60m },
                    { 2, 90, 1, 2, 8, 65m },
                    { 3, 120, 1, 3, 6, 70m },
                    { 4, 90, 2, 1, 10, 30m },
                    { 5, 90, 2, 2, 10, 35m },
                    { 6, 60, 3, 1, 12, 20m },
                    { 7, 60, 3, 2, 12, 25m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RoutineSet",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoutinesExercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Routines",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
