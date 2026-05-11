namespace GymQuest.Models.Entities;

public class Workout
{
    public int Id { get; set; }
    public int? RoutineId { get; set; }
    public Routine? Routine { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime WorkoutDate { get; set; } = DateTime.UtcNow;
    public int? DurationMinutes { get; set; }
    public int EarnedXP { get; set; } = 0;
    public bool IsCompleted { get; set; } = false;
    public List<WorkoutExercise> Exercises { get; set; } = new();
}