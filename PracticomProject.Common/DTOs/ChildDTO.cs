using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Common.DTOs
{
    public class ChildDTO
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public ChildDTO()
        {

        }
        public ChildDTO(int id, string tz, string fullName, DateTime birthDate)
        {
            Id = id;
            Tz = tz;
            FullName = fullName;
            BirthDate = birthDate;
        }
    }
}
