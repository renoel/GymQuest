using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymQuest.Data.Migrations
{
    /// <inheritdoc />
    public partial class CSAchievementTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ExperienceReward = table.Column<int>(type: "integer", nullable: false),
                    BadgeImageUrl = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MuscleGroup = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    BaseXP = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoutineExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoutineId = table.Column<int>(type: "integer", nullable: false),
                    ExerciseId = table.Column<int>(type: "integer", nullable: false),
                    OrderIndex = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutineExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutineExercises_Routines_RoutineId",
                        column: x => x.RoutineId,
                        principalTable: "Routines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoutineId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    WorkoutDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DurationMinutes = table.Column<int>(type: "integer", nullable: true),
                    EarnedXP = table.Column<int>(type: "integer", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_Routines_RoutineId",
                        column: x => x.RoutineId,
                        principalTable: "Routines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoutineSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoutineExerciseId = table.Column<int>(type: "integer", nullable: false),
                    SetNumber = table.Column<int>(type: "integer", nullable: false),
                    TargetReps = table.Column<int>(type: "integer", nullable: false),
                    TargetWeight = table.Column<decimal>(type: "numeric", nullable: true),
                    RestSeconds = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutineSets_RoutineExercises_RoutineExerciseId",
                        column: x => x.RoutineExerciseId,
                        principalTable: "RoutineExercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkoutId = table.Column<int>(type: "integer", nullable: false),
                    ExerciseId = table.Column<int>(type: "integer", nullable: false),
                    OrderIndex = table.Column<int>(type: "integer", nullable: false),
                    EarnedXP = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkoutExerciseId = table.Column<int>(type: "integer", nullable: false),
                    SetNumber = table.Column<int>(type: "integer", nullable: false),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutSets_WorkoutExercises_WorkoutExerciseId",
                        column: x => x.WorkoutExerciseId,
                        principalTable: "WorkoutExercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "BadgeImageUrl", "Description", "ExperienceReward", "Name" },
                values: new object[,]
                {
                    { 1, "images/badges/badge_1.png", "Get 10k steps", 100, "10k steps" },
                    { 2, "images/badges/badge_2.png", "Get 20k steps", 200, "20k steps" },
                    { 3, "images/badges/badge_3.png", "Get 30k steps", 300, "30k steps" },
                    { 4, "images/badges/badge_4.png", "Get 40k steps", 400, "40k steps" },
                    { 5, "images/badges/badge_5.png", "Get 50k steps", 500, "50k steps" },
                    { 6, "images/badges/badge_6.png", "Get 60k steps", 600, "60k steps" },
                    { 7, "images/badges/badge_7.png", "Get 70k steps", 700, "70k steps" },
                    { 8, "images/badges/badge_8.png", "Get 80k steps", 800, "80k steps" },
                    { 9, "images/badges/badge_9.png", "Get 90k steps", 900, "90k steps" },
                    { 10, "images/badges/badge_10.png", "Get 100k steps", 1000, "100k steps" }
                });

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
                columns: new[] { "Id", "Description", "IsDefault", "Name" },
                values: new object[,]
                {
                    { 1, "Chest, shoulders and triceps", true, "Push" },
                    { 2, "Back and biceps", true, "Pull" },
                    { 3, "Heavy leg workout", true, "Legs" }
                });

            migrationBuilder.InsertData(
                table: "RoutineExercises",
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
                table: "RoutineSets",
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

            migrationBuilder.CreateIndex(
                name: "IX_RoutineExercises_ExerciseId",
                table: "RoutineExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineExercises_RoutineId",
                table: "RoutineExercises",
                column: "RoutineId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineSets_RoutineExerciseId",
                table: "RoutineSets",
                column: "RoutineExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_ExerciseId",
                table: "WorkoutExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_RoutineId",
                table: "Workouts",
                column: "RoutineId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSets_WorkoutExerciseId",
                table: "WorkoutSets",
                column: "WorkoutExerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "RoutineSets");

            migrationBuilder.DropTable(
                name: "WorkoutSets");

            migrationBuilder.DropTable(
                name: "RoutineExercises");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Routines");
        }
    }
}
