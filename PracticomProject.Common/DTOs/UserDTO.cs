using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Common.DTOs
{
    public enum EGENDERDTO { Male=1, Female=2 };
    public enum EHMODTO { Maccabi=1, Leumit=2, Clalit=3, Meuhedet =4};
    public class UserDTO
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public EGENDERDTO EGender { get; set; }
        public EHMODTO EHmo { get; set; }
        public List<ChildDTO> Children { get; set; }

        public UserDTO()
        {

        }
        public UserDTO(int id, string tz, string firstName, string lastName, DateTime birthDate, EGENDERDTO eGender, EHMODTO eHmo, List<ChildDTO> children)
        {
            Id = id;
            Tz = tz;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EGender = eGender;
            EHmo = eHmo;
            Children = children;
        }
    }
}
