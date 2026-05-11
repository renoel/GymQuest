using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models.Entities;

public class WorkoutSet
{
    public int Id { get; set; }
    public int WorkoutExerciseId { get; set; }
    public WorkoutExercise WorkoutExercise { get; set; } = null!;
    public int SetNumber { get; set; }
    public int Reps { get; set; }
    public decimal Weight { get; set; }
    public bool IsCompleted { get; set; } = false;
}
