using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Repositories.Entities
{
    public enum EGENDER { Male = 1, Female = 2 };
    public enum EHMO { Maccabi = 1, Leumit = 2, Clalit = 3, Meuhedet = 4 };
    public class User
    {
        [Key, Required]
        public int Id { get; set; }
        public string Tz { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public EGENDER EGender { get; set; }
        public EHMO EHmo { get; set; }
        public List<Child> Children { get; set; }
        public User()
        {

        }
        public User(int id, string tz, string firstName, string lastName, DateTime birthDate, EGENDER eGender, EHMO eHMO)
        {
            Id = id;
            Tz = tz;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            EGender = eGender;
            EHmo = eHMO;
        }
        public User(User user)
        {
            Id = user.Id;
            Tz = user.Tz;
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            EGender = user.EGender;
            EHmo = user.EHmo;
        }
    }
}
