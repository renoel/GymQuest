using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models.Entities;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string MuscleGroup { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int BaseXP { get; set; }
}
