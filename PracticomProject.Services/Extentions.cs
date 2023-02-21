using Microsoft.Extensions.DependencyInjection;
using PracticomProject.Context;
using PracticomProject.Repositories;
using PracticomProject.Repositories.Interfaces;
using PracticomProject.Services.Interfaces;
using PracticomProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped<IContext, MyDbContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IChildService, ChildService>();
            services.AddAutoMapper(typeof(Mapping));
           
            return services;
        }
    }
}
