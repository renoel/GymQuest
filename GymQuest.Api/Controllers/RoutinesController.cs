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
        public async Task<ActionResult<List<RoutineSummaryDto>>> GetRoutines()
        {
            var routines = await _db.Routines
                .AsNoTracking()
                .OrderBy(r => r.Id)
                .Select(r => new RoutineSummaryDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                })
                .ToListAsync();

            return Ok(routines);
        }
    }
}
