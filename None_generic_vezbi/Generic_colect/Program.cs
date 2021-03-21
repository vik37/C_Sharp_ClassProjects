using System;
using System.Collections.Generic;
using System.Collections;

namespace Generic_colect
{
    public class Students
    {
        public string Name { get; set; }
        public int Id { get; set; }
        Something someGood = Something.Good;
        Something someBad = Something.Bad;
        public Students()
        {

        }
        public Students(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
    class Program
    {
        public static object Name { get; private set; }

        static void Main(string[] args)
        {
            var intList = new List<int>();

            intList.Add(10);
            intList.Add(25);


            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
            var students = new List<Students>()
            {
               new Students("Petar Pan",1),
               new Students("Paja Patak",2),
               new Students("Krali Marko",3)
            };

            var students2 = new Students("Superman", 4);

            students.Add(students2);
            intList.Add(54);
            
            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Id);
            }

            Dictionary<int, string> someDic = new Dictionary<int, string>();
            someDic.Add(1, "one");
            someDic.Add(2, "two");
            someDic.Add(3, "three");

            //foreach (KeyValuePair<int,string> item in someDic)
            //{
            //    Console.WriteLine("Key: {0}, value: {1}",item.Key,item.Value);
            //}
            Console.WriteLine(someDic[1]);

            Console.ReadLine();
        }
    }
}
