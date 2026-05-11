using GymQuest.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace GymQuest.Data.Seed;

public static class DefaultRoutineSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        SeedExercises(modelBuilder);
        SeedRoutines(modelBuilder);
        SeedRoutineExercises(modelBuilder);
        SeedRoutineSets(modelBuilder);
        SeedAchievements(modelBuilder);
    }

    private static void SeedExercises(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>().HasData(

            new Exercise
            {
                Id = 1,
                Name = "Bench Press",
                MuscleGroup = "Chest",
                Category = "Strength",
                BaseXP = 35
            },

            new Exercise
            {
                Id = 2,
                Name = "Shoulder Press",
                MuscleGroup = "Shoulders",
                Category = "Strength",
                BaseXP = 30
            },

            new Exercise
            {
                Id = 3,
                Name = "Tricep Pushdown",
                MuscleGroup = "Arms",
                Category = "Isolation",
                BaseXP = 20
            },

            new Exercise
            {
                Id = 4,
                Name = "Pull Up",
                MuscleGroup = "Back",
                Category = "Bodyweight",
                BaseXP = 40
            },

            new Exercise
            {
                Id = 5,
                Name = "Barbell Row",
                MuscleGroup = "Back",
                Category = "Strength",
                BaseXP = 35
            },

            new Exercise
            {
                Id = 6,
                Name = "Bicep Curl",
                MuscleGroup = "Arms",
                Category = "Isolation",
                BaseXP = 20
            },

            new Exercise
            {
                Id = 7,
                Name = "Squat",
                MuscleGroup = "Legs",
                Category = "Strength",
                BaseXP = 45
            },

            new Exercise
            {
                Id = 8,
                Name = "Leg Press",
                MuscleGroup = "Legs",
                Category = "Machine",
                BaseXP = 35
            },

            new Exercise
            {
                Id = 9,
                Name = "Leg Curl",
                MuscleGroup = "Legs",
                Category = "Isolation",
                BaseXP = 20
            }
        );
    }

    private static void SeedRoutines(ModelBuilder modelBuilder)
    {
        var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        modelBuilder.Entity<Routine>().HasData(

            new Routine
            {
                Id = 1,
                Name = "Push",
                Description = "Chest, shoulders and triceps",
                IsDefault = true
            },

            new Routine
            {
                Id = 2,
                Name = "Pull",
                Description = "Back and biceps",
                IsDefault = true
            },

            new Routine
            {
                Id = 3,
                Name = "Legs",
                Description = "Heavy leg workout",
                IsDefault = true
            }
        );
    }

    private static void SeedRoutineExercises(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoutineExercise>().HasData(

            // PUSH
            new { Id = 1, RoutineId = 1, ExerciseId = 1, OrderIndex = 1 },
            new { Id = 2, RoutineId = 1, ExerciseId = 2, OrderIndex = 2 },
            new { Id = 3, RoutineId = 1, ExerciseId = 3, OrderIndex = 3 },

            // PULL
            new { Id = 4, RoutineId = 2, ExerciseId = 4, OrderIndex = 1 },
            new { Id = 5, RoutineId = 2, ExerciseId = 5, OrderIndex = 2 },
            new { Id = 6, RoutineId = 2, ExerciseId = 6, OrderIndex = 3 },

            // LEGS
            new { Id = 7, RoutineId = 3, ExerciseId = 7, OrderIndex = 1 },
            new { Id = 8, RoutineId = 3, ExerciseId = 8, OrderIndex = 2 },
            new { Id = 9, RoutineId = 3, ExerciseId = 9, OrderIndex = 3 }
        );
    }

    private static void SeedRoutineSets(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoutineSet>().HasData(

            // Bench Press
            new { Id = 1, RoutineExerciseId = 1, SetNumber = 1, TargetReps = 8, TargetWeight = (decimal?)60, RestSeconds = 90 },
            new { Id = 2, RoutineExerciseId = 1, SetNumber = 2, TargetReps = 8, TargetWeight = (decimal?)65, RestSeconds = 90 },
            new { Id = 3, RoutineExerciseId = 1, SetNumber = 3, TargetReps = 6, TargetWeight = (decimal?)70, RestSeconds = 120 },

            // Shoulder Press
            new { Id = 4, RoutineExerciseId = 2, SetNumber = 1, TargetReps = 10, TargetWeight = (decimal?)30, RestSeconds = 90 },
            new { Id = 5, RoutineExerciseId = 2, SetNumber = 2, TargetReps = 10, TargetWeight = (decimal?)35, RestSeconds = 90 },

            // Tricep Pushdown
            new { Id = 6, RoutineExerciseId = 3, SetNumber = 1, TargetReps = 12, TargetWeight = (decimal?)20, RestSeconds = 60 },
            new { Id = 7, RoutineExerciseId = 3, SetNumber = 2, TargetReps = 12, TargetWeight = (decimal?)25, RestSeconds = 60 }
        );
    }

    private static void SeedAchievements(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Achievement>().HasData(
            new { Id = 1, Name = "10k steps", Description = "Get 10k steps", ExperienceReward = 100, BadgeImageUrl = "images/badges/badge_1.png" },
            new { Id = 2, Name = "20k steps", Description = "Get 20k steps", ExperienceReward = 200, BadgeImageUrl = "images/badges/badge_2.png" },
            new { Id = 3, Name = "30k steps", Description = "Get 30k steps", ExperienceReward = 300, BadgeImageUrl = "images/badges/badge_3.png" },
            new { Id = 4, Name = "40k steps", Description = "Get 40k steps", ExperienceReward = 400, BadgeImageUrl = "images/badges/badge_4.png" },
            new { Id = 5, Name = "50k steps", Description = "Get 50k steps", ExperienceReward = 500, BadgeImageUrl = "images/badges/badge_5.png" },
            new { Id = 6, Name = "60k steps", Description = "Get 60k steps", ExperienceReward = 600, BadgeImageUrl = "images/badges/badge_6.png" },
            new { Id = 7, Name = "70k steps", Description = "Get 70k steps", ExperienceReward = 700, BadgeImageUrl = "images/badges/badge_7.png" },
            new { Id = 8, Name = "80k steps", Description = "Get 80k steps", ExperienceReward = 800, BadgeImageUrl = "images/badges/badge_8.png" },
            new { Id = 9, Name = "90k steps", Description = "Get 90k steps", ExperienceReward = 900, BadgeImageUrl = "images/badges/badge_9.png" },
            new { Id = 10, Name = "100k steps", Description = "Get 100k steps", ExperienceReward = 1000, BadgeImageUrl = "images/badges/badge_10.png" }
        );
    }
}