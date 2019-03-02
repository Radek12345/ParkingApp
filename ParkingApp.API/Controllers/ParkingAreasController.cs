using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Controllers.Resources;
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
        private readonly IMapper mapper;

        public ParkingAreasController(IRepository<ParkingArea> repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var areas = await repo.GetAll();
            var areasToRetun = mapper.Map<IEnumerable<ParkingAreaResource>>(areas);
            return Ok(areasToRetun);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var area = await repo.Get(id);
            var areaToReturn = mapper.Map<ParkingAreaResource>(area);
            return Ok(areaToReturn);
        }
    }
}