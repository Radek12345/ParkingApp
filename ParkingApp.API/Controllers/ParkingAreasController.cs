using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingApp.API.Controllers.Resources;
using ParkingApp.API.Core;
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
        private readonly IUnitOfWork unit;

        public ParkingAreasController(IRepository<ParkingArea> repo, IMapper mapper, IUnitOfWork unit)
        {
            this.unit = unit;
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

        [HttpPost]
        public async Task<IActionResult> Add(ParkingAreaResource resource)
        {
            var entity = mapper.Map<ParkingAreaResource, ParkingArea>(resource);

            repo.Add(entity);
            await unit.CompleteAsync();

            return Ok(mapper.Map<ParkingArea, ParkingAreaResource>(entity));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ParkingAreaResource resource)
        {
            var entity = await repo.Get(id);

            if (entity == null)
                return NotFound();

            entity.LastEdit = DateTime.Now;                

            mapper.Map<ParkingAreaResource, ParkingArea>(resource, entity);
            await unit.CompleteAsync();

            return Ok(mapper.Map<ParkingArea, ParkingAreaResource>(entity));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await repo.Get(id);

            if (entity == null)
                return NotFound();

            repo.Remove(entity);
            await unit.CompleteAsync();

            return Ok(id);
        }
    }
}