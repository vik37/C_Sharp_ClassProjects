using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorphismExercise.Identity
{
    public class TemproraryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Temporary Time");
        }
    }

}
