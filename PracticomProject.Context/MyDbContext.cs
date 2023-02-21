using Microsoft.EntityFrameworkCore;
using PracticomProject.Repositories.Entities;
using PracticomProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticomProject.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RutiPracticomDb;Trusted_Connection=True");
        }
    }
}
