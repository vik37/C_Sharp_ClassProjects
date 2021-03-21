using Person;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqVezbiTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonClass> people = ListMenager.LoadSempleData();

            //people = people.OrderByDescending(p => p.LastName).ThenByDescending(x => x.YearsExperience).ToList();
            //people = people.Where(p => p.YearsExperience > 10 && p.BirthDay.Month == 6).OrderBy(p => p.FirstName).ToList();
            //foreach (var item in people)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} ({item.BirthDay.ToShortDateString()}) | \n  Experience: {item.YearsExperience}");
            //}

            //int YearsTotal = people.Sum(p => p.YearsExperience);
            int YearsTotal = people.Where(p => p.BirthDay.Month == 6).Sum(p => p.YearsExperience);

            Console.WriteLine($"Total Years Ecperiens: ({YearsTotal})");
            

            Console.ReadLine();
        }
    }
}
