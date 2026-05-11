using System;
using System.Collections.Generic;
using System.Text;

namespace GymQuest.Models.Entities;

public class Routine
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsDefault { get; set; } = true;
}