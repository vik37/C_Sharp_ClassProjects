using PolimorphismExercise.Identity;
using System;

namespace PolimorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.PrintFullName();
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemproraryEmployee();

            foreach (var e in employees)
            {
                e.PrintFullName();
            }
            Console.ReadLine();
        }
    }
}
