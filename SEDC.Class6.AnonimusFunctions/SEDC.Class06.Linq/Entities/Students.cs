using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Linq.Entities
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public List<Subject> Subjects { get; set;  }
    }
}
