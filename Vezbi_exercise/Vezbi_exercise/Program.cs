using System;
using System.Collections.Generic;
using Vezbi_exercise.Helper;
using Vezbi_exercise.Students;
using Vezbi_exercise.Students.Scools;

namespace Vezbi_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Children> someStudents = new List<Children>() { 
                new Children() {FirstName = "Pero",LastName = "Goshev",Grades = 2, DateOfBirth = new DateTime(1973, 4, 15) },
                new Children() {FirstName = "Pablo",LastName = "Eskobar",Grades = 4, DateOfBirth = new DateTime(1989, 12, 12) },
                new Children() {FirstName = "Goce",LastName = "Delcev",Grades = 5, DateOfBirth = new DateTime(2003, 4, 5) },
                new Children() {FirstName = "Goce",LastName = "Sedlovski",Grades = 3, DateOfBirth = new DateTime(1998, 8, 7) },
                new Children() {FirstName = "Biljana",LastName = "Crvenkovska",Grades = 5, DateOfBirth = new DateTime(2014, 9, 23) },
                  };
            List<HigthScools> hightSchools = new List<HigthScools>()
            {
                new HigthScools(){NamesScool = "Koce Metalec",Classes = 1,Teachers = "Daliborka"},
                new HigthScools(){NamesScool = "Josip Broz Tito",Classes = 2,Teachers = "Mariionka"},
                new HigthScools(){NamesScool = "DimitR vLhov",Classes = 1, Teachers = "Dusko"},
                new HigthScools(){NamesScool = "Hemisko",Classes = 3,Teachers = "Blagorodna"},
                new HigthScools(){NamesScool = "Krste Petkov Misirkov",Classes = 5,Teachers = "KRsto"}
            };
            someStudents.ForEach(s => s.ShowAge());
            //foreach (var student in someStudents)
            //{
             var a =   ReturnClass.ReturnFirstNames();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a);
            var b = ReturnClass.Dic;
            // }

            foreach (var item in b)
            {
                
                Console.WriteLine($"Students {item.Key.FirstName} Hight School {item.Value.Classes}");
            }
            Console.WriteLine("abre umreee");
            Console.ReadLine();
        }
    }
}
