using GymQuest.Models;
using Microsoft.EntityFrameworkCore;

namespace GymQuest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Workout> Workouts { get; set; }
}