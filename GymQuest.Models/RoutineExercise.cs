using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models
{
    public class RoutineExercise
    {
        public int Id { get; set; }
        public int RoutineId { get; set; }
        public Routine Routine { get; set; } = null!;
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = null!;
        public int OrderIndex { get; set; }
        public List<RoutineSet> Sets { get; set; } = new();
    }
}
