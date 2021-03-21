using SEDC.Class06.Linq.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class06.Linq.Db
{
    public static class DataBase
    {
        public static List<Students> Students = new List<Students>()
        {
            new Students(){ Id = 1,FirstName = "Viktor",LastName = "Zafirovski" },
            new Students(){ Id = 2,FirstName = "Jill",LastName = "Wane" },
            new Students(){ Id = 3,FirstName = "Pere",LastName = "Tosev" },
            new Students(){ Id = 4,FirstName = "Pitu",LastName = "Guli" },
            new Students(){ Id = 5,FirstName = "Hristo",LastName = "Manevski" },
        };
        public static List<Subject> Subjects = new List<Subject>()
        {
            new Subject(){ Id = 1,Name = "C-Sharp Basic",NumOfClasses = 15,Trainer = "Milorad Cekic",IsMandatory = true},
            new Subject(){ Id = 2,Name = "C-Sharp Advanced",NumOfClasses = 15,Trainer = "Goce Kabov",IsMandatory = true},
            new Subject(){ Id = 3,Name = "JavaScript Basic",NumOfClasses = 25,Trainer = "Gery Oldman",IsMandatory = false},
            new Subject(){ Id = 4,Name = "HTML",NumOfClasses = 10,Trainer = "Jhon Doe",IsMandatory = true},
        };
        public static void InitDb()
        {
            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[1] };
            Students[0].Subjects = new List<Subject>() { Subjects[3], Subjects[2] };
        }
    }
}
