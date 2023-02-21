using Microsoft.AspNetCore.Mvc;
using PracticomProject.Common.DTOs;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<UserDTO> Updete(int id, [FromBody] UserModel model)
        {
            return await _userService.UpdateAsync(new UserDTO(id, model.Tz, model.FirstName, model.LastName, model.BirthDate, (EGENDERDTO)model.eGender, (EHMODTO)model.eHmo, model.children));
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {

            var result=  await _userService.AddAsync(new UserDTO(model.Id, model.Tz, model.FirstName, model.LastName, model.BirthDate, (EGENDERDTO)model.eGender, (EHMODTO)model.eHmo, model.children));
            return result;
        }
    }
}
