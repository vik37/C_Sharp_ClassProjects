using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbi_LINQ_SQL.MainClass
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Doors { get; set; }
        public string Type { get; set; }
        public Car()
        {

        }
        public Car(int id, string name, int doors, string type)
        {
            Id = id;
            Name = name;
            Doors = doors;
            Type = type;
        }
    }
}
