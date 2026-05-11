namespace GymQuest.Models.Entities;

public class Achievement
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int ExperienceReward { get; set; } = 0;
    public string BadgeImageUrl { get; set; } = string.Empty;
}

