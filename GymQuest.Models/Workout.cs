namespace GymQuest.Models;

public class Workout
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime WorkoutDate { get; set; } = DateTime.UtcNow;
    public int? DurationMinutes { get; set; }
    public int EarnedXP { get; set; } = 0;
    public bool IsCompleted { get; set; } = false;
}