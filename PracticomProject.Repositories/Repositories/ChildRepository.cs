using Microsoft.EntityFrameworkCore;
using PracticomProject.Repositories.Entities;
using PracticomProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child child)
        {
            var c = new Child(child);
            _context.Children.Add(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(GetByIdAsync(id).Result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var c = _context.Children.Update(child);
            await _context.SaveChangesAsync();
            return c.Entity;
        }
    }
}
