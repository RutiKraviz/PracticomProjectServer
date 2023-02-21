using PracticomProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomProject.Mock
{
    public class MockContext
    {
        public List<User> Users { get; set; }
        public List<Child> Children { get; set; }
    }
}
