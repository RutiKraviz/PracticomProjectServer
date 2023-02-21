using Microsoft.AspNetCore.Mvc;
using PracticomProject.Common.DTOs;
//using PracticomProject.Repositories.Entities;
//using PracticomProject.Repositories.Interfaces;
using PracticomProject.Services.Interfaces;
using PracticomProject.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticomProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController:ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<ChildDTO> Updete(int id, [FromBody] ChildModel model)
        {
            return await _childService.UpdateAsync(new ChildDTO(model.Id, model.Tz, model.FullName, model.BirthDate));
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildModel model)
        {
            return await _childService.AddAsync(new ChildDTO(model.Id, model.Tz, model.FullName, model.BirthDate));
        }
    }
}
