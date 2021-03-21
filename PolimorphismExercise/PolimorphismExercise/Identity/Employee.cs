using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorphismExercise.Identity
{
    public class Employee
    {
        public string FirstName { get; set; } = "FN";
        public string LastName { get; set; } = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
