using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Core.Domain;
using ParkingApp.API.Core.Repositories;
using ParkingApp.API.Persistence;

namespace ParkingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingAreasController : ControllerBase
    {
        private readonly IRepository<ParkingArea> repo;

        public ParkingAreasController(IRepository<ParkingArea> repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var areas = await repo.GetAll();
            return Ok(areas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var area = await repo.Get(id);
            return Ok(area);
        }
    }
}