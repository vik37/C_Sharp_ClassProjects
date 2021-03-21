using System;
using System.Collections.Generic;
using System.Linq;
using Vezbi_LINQ_SQL.MainClass;

namespace Vezbi_LINQ_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>()
            {
                new Car(){Id = 1, Name = "Mercedes",Doors = 4, Type = "S-Class"},
                new Car(){Id = 2, Name = "Fiat", Doors = 3, Type = "Punto"},
                new Car(){Id = 3, Name = "Peugeot", Doors = 4, Type = "206"},
                new Car(){ Id = 4, Name = "Skoda",Doors = 4, Type = "Fabia"}
            };

            //car.ForEach(c => Console.WriteLine(c.Name));

            var carOrdered = new Dictionary<int, Car>()
            {
                {1, new Car() { Id = 1, Name = "Mercedes", Doors = 4, Type = "S-Class" } },
                {2,  new Car(){Id = 2, Name = "Fiat", Doors = 3, Type = "Punto"}},
                {3,  new Car(){Id = 3, Name = "Peugeot", Doors = 4, Type = "206"}},
                {4, new Car(){ Id = 4, Name = "Skoda",Doors = 4, Type = "Fabia"}}
            };

            var firstCarWithLambdaExpresio = car.Where(c => c.Name.StartsWith("M")).ToList();
            foreach (var item in firstCarWithLambdaExpresio)
            {
                Console.WriteLine(item.Type);
            }

            var firstCarWithLambdaExpresioQuery = (from someCar in car
                                                   where someCar.Name.StartsWith("S")
                                                   select someCar.Type).ToList();

            foreach (var item in firstCarWithLambdaExpresioQuery)
            {
                Console.WriteLine(item);
            }

            var firstCarOfTye = car.OfType<string>().Where(c => c.Contains("k")).ToList();
            foreach (var item in firstCarOfTye)
            {
                Console.WriteLine(item);
            }

            char[] arr = new char[] { '*' };
            int count = 0;
            while(count < 5)
            {
                Console.WriteLine(arr);
                count++;
            }
            Console.ReadLine();
        }
    }
}
