using GymQuest.Data;
using GymQuest.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymQuest.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AchievementsController : ControllerBase
{
    private readonly AppDbContext _db;

    public AchievementsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<AchievementDto>>> GetAchievements()
    {
        var achievements = await _db.Achievements
            .AsNoTracking()
            .OrderBy(a => a.Id)
            .Select(a => new AchievementDto
            {
                Id = a.Id,
                Name = a.Name,
                Description = a.Description,
                ExperienceReward = a.ExperienceReward,
                BadgeImageUrl = a.BadgeImageUrl
            })
            .ToListAsync();

        return Ok(achievements);
    }
}


