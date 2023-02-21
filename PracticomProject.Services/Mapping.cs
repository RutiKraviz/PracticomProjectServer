using AutoMapper;
using PracticomProject.Common.DTOs;
using PracticomProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Services
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Child, ChildDTO>().ReverseMap();
            // CreateMap<List<ChildDTO>, UserDTO>().ReverseMap();
            CreateMap<List<ChildDTO>, UserDTO>().ReverseMap().ConvertUsing(user => user.Children.Select(c => new ChildDTO { Id = c.Id, FullName = c.FullName, Tz = c.Tz, BirthDate = c.BirthDate }).ToList());
        }
    }
}
