using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorphismExercise.Identity
{
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Full Time");
        }
    }
}
