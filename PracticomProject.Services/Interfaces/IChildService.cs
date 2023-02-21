using PracticomProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();
        Task<ChildDTO> GetByIdAsync(int id);
        Task<ChildDTO> AddAsync(ChildDTO child);
        Task<ChildDTO> UpdateAsync(ChildDTO child);
        Task DeleteAsync(int id);
    }
}
