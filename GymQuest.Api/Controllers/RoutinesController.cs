using GymQuest.Data;
using GymQuest.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymQuest.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoutinesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RoutinesController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoutineDto>>> GetRoutines()
        {
            var routines = await _db.Routines
                .AsNoTracking()
                .Include(r => r.Exercises)
                    .ThenInclude(re => re.Exercise)
                .Include(r => r.Exercises)
                    .ThenInclude(re => re.Sets)
                .OrderBy(r => r.Id)
                .Select(r => new RoutineDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description,
                    Exercises = r.Exercises
                        .OrderBy(re => re.OrderIndex)
                        .Select(re => new RoutineExerciseDto
                        {
                            Id = re.Id,
                            OrderIndex = re.OrderIndex,
                            ExerciseName = re.Exercise.Name,
                            MuscleGroup = re.Exercise.MuscleGroup,
                            Category = re.Exercise.Category,
                            BaseXP = re.Exercise.BaseXP,
                            Sets = re.Sets
                                .OrderBy(s => s.SetNumber)
                                .Select(s => new RoutineSetDto
                                {
                                    SetNumber = s.SetNumber,
                                    TargetReps = s.TargetReps,
                                    TargetWeight = s.TargetWeight,
                                    RestSeconds = s.RestSeconds
                                })
                                .ToList()
                        })
                        .ToList()
                })
                .ToListAsync();

            return Ok(routines);
        }
    }
}
