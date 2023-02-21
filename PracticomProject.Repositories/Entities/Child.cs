using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Repositories.Entities
{
    public class Child
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Child()
        {

        }
        public Child(int id, string tz, string fullName, DateTime birthDate)
        {
            Id = id;
            Tz = tz;
            FullName = fullName;
            BirthDate = birthDate;
        }
        public Child(Child child)
        {
            Id = child.Id;
            Tz = child.Tz;
            FullName = child.FullName;
           // BirthDate = child.BirthDate;
        }
    }
}
