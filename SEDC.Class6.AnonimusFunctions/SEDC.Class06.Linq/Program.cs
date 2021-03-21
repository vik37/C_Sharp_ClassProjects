using System;
using SEDC.Class06.Linq.Db;
using SEDC.Class06.Linq.Entities;
using System.Linq;

namespace SEDC.Class06.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase.InitDb();

            var bobSql = from x in DataBase.Students
                         where x.FirstName == "Pere"
                         select x;
            var bobMethod = DataBase.Students
                .Where(s => s.FirstName == "Pere");
                
            var fullNameSql = (from Students in DataBase.Students
                              select new StudentBasicInfo()
                              {
                                  FullName = $"{Students.FirstName} {Students.LastName}"
                              }).ToList();

            fullNameSql.Add(new StudentBasicInfo { FullName = "Imposter." });

            foreach (var studentInfo in fullNameSql)
            {

            }
            var cSharpBasicStudents = (from student in DataBase.Students
                                       where student.Subjects.Contains((from subject in DataBase.Subjects
                                                                        where subject.Name == "C-Sharp Basic"
                                                                        select subject).FirstOrDefault())
                                       select student);
            //var cSharpBasicStdu = DataBase.Students.Where(student =>
            //student.Subjects.Contains(
            //student.Subjects.Where(subject => subject.Name == "C-Sharp Basic")))

            Console.ReadLine();
        }
    }
}
