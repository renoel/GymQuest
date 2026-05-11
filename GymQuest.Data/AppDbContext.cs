using GymQuest.Models.Entities;
using Microsoft.EntityFrameworkCore;
using GymQuest.Data.Seed;
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
    public DbSet<RoutineExercise> RoutineExercises{ get; set; }
    public DbSet<Achievement> Achievements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        DefaultRoutineSeeder.Seed(modelBuilder);
    }
}