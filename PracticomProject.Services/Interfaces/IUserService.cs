﻿using PracticomProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();
        Task<UserDTO> GetByIdAsync(int id);
        Task<UserDTO> AddAsync(UserDTO user);
        Task<UserDTO> UpdateAsync(UserDTO user);
        Task DeleteAsync(int id);
    }
}
