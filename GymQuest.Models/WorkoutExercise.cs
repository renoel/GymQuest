using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models
{
    public class WorkoutExercise
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; } = null!;
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public int OrderIndex { get; set; }
        public int EarnedXP { get; set; } = 0;
        public List<WorkoutSet> Sets { get; set; } = new();
    }
}
