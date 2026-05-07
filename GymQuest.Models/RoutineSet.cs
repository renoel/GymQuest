using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models;

public class RoutineSet
{
    public int Id { get; set; }
    public int RoutineExerciseId { get; set; }
    public RoutineExercise RoutineExercise { get; set; } = null!;
    public int SetNumber { get; set; }
    public int TargetReps { get; set; }
    public decimal? TargetWeight { get; set; }
    public int RestSeconds { get; set; } = 60;
}