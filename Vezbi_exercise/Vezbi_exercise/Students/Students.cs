using System;
using System.Collections.Generic;
using System.Text;
using Vezbi_exercise.Helper;

namespace Vezbi_exercise.Students
{
    public class Children
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int Age { get; set; }
        public int Grades { get; set; }
        public DateTime DateOfBirth;
        public Children()
        {

        }
        public Children(string firstName, string lastName, int age, int grades, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grades = grades;
            DateOfBirth = dateOfBirth;
        }
        
        public void ShowAge()
        {
            ReturnClass.ReturnDate(DateOfBirth);
            Age = ReturnClass.alloo;
            Console.WriteLine($"{Age}");
        }
        
    }
}
