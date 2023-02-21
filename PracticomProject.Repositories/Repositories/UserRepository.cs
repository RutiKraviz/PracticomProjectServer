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
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;
        private readonly IChildRepository _childRepository;
        public UserRepository(IContext context, IChildRepository childRepository)
        {
            _context = context;
            _childRepository = childRepository;
        }
        public async Task<User> AddAsync(User user)
        {
            var u = new User(user);
           var userFromDB= _context.Users.Add(u);
            await _context.SaveChangesAsync();
            List<Child> result = new List<Child>();
            foreach (var item in user.Children)
            {
                result.Add(await _childRepository.AddAsync(item));
            }
            userFromDB.Entity.Children = result;
            return userFromDB.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Users.Remove(GetByIdAsync(id).Result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {
            var u = _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return u.Entity;
        }
    }
}
