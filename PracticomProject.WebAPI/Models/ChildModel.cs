using PracticomProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticomProject.WebAPI.Models
{
    public class ChildModel
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
