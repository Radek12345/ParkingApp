using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Core.Domain;
using ParkingApp.API.Persistence;

namespace ParkingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingAreasController : ControllerBase
    {
        private readonly ParkingDbContext context;

        public ParkingAreasController(ParkingDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var areas = await context.ParkingAreas.ToListAsync();
            return Ok(areas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var areas = await context.ParkingAreas.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(areas);
        }
    }
}