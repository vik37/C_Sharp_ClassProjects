using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Linq.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Trainer { get; set; }
        public int NumOfClasses { get; set; }
        public bool IsMandatory { get; set; }
    }
}
