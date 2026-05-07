using GymQuest.Models;
using Microsoft.EntityFrameworkCore;

namespace GymQuest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<WorkoutSet> WorkoutSets{ get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
    public DbSet<Routine> Routines{ get; set; }
    public DbSet<RoutineSet> RoutineSets{ get; set; }
    public DbSet<RoutineExercise> RoutinesExercises{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // EXERCISES
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

        // ROUTINES
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

        // ROUTINE EXERCISES
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

        // ROUTINE SETS
        modelBuilder.Entity<RoutineSet>().HasData(

            // PUSH
            new { Id = 1, RoutineExerciseId = 1, SetNumber = 1, TargetReps = 8, TargetWeight = (decimal?)60, RestSeconds = 90 },
            new { Id = 2, RoutineExerciseId = 1, SetNumber = 2, TargetReps = 8, TargetWeight = (decimal?)65, RestSeconds = 90 },
            new { Id = 3, RoutineExerciseId = 1, SetNumber = 3, TargetReps = 6, TargetWeight = (decimal?)70, RestSeconds = 120 },

            new { Id = 4, RoutineExerciseId = 2, SetNumber = 1, TargetReps = 10, TargetWeight = (decimal?)30, RestSeconds = 90 },
            new { Id = 5, RoutineExerciseId = 2, SetNumber = 2, TargetReps = 10, TargetWeight = (decimal?)35, RestSeconds = 90 },

            new { Id = 6, RoutineExerciseId = 3, SetNumber = 1, TargetReps = 12, TargetWeight = (decimal?)20, RestSeconds = 60 },
            new { Id = 7, RoutineExerciseId = 3, SetNumber = 2, TargetReps = 12, TargetWeight = (decimal?)25, RestSeconds = 60 }

        );
    }
}