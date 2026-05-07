using GymQuest.Data;
using GymQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymQuest.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkoutsController : ControllerBase
{
    private readonly AppDbContext _db;

    public WorkoutsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<Workout>>> Get()
    {
        return await _db.Workouts
            .OrderByDescending(w => w.WorkoutDate)
            .ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Workout>> Create(Workout workout)
    {
        _db.Workouts.Add(workout);
        await _db.SaveChangesAsync();

        return Ok(workout);
    }
}