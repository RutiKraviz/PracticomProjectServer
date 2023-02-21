using Microsoft.Extensions.DependencyInjection;
using PracticomProject.Repositories.Interfaces;
using PracticomProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Repositories
{
    public static class Extentions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();
           
            return services;
        }
    }
}
