using Microsoft.EntityFrameworkCore;
using PracticomProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticomProject.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
