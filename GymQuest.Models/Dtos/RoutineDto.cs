namespace GymQuest.Models.Dtos
{
    public class RoutineDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<RoutineExerciseDto> Exercises { get; set; } = new();
    }

    public class RoutineExerciseDto
    {
        public int Id { get; set; }
        public int OrderIndex { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string MuscleGroup { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public int BaseXP { get; set; }
        public List<RoutineSetDto> Sets { get; set; } = new();
    }

    public class RoutineSetDto
    {
        public int SetNumber { get; set; }
        public int TargetReps { get; set; }
        public decimal? TargetWeight { get; set; }
        public int RestSeconds { get; set; }
    }
}
