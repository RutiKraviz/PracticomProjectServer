using PracticomProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticomProject.WebAPI.Models
{
    //public enum EGENDER { Male, Female };
    //public enum EHMO { Maccabi, Leumit, Clalit, Meuhedet };
    public class UserModel
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public int eGender { get; set; }
        public int eHmo { get; set; }
        public List<ChildDTO> children { get; set; }
    }
}
