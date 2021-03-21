using System;
using System.Collections;

namespace NongenericColection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList somethingOfSomething = new ArrayList();
            somethingOfSomething.Add(100);
            somethingOfSomething.Add("Seavus education development center");
            somethingOfSomething.Add(true);
            foreach (var item in somethingOfSomething)
            {
                Console.WriteLine(item);
            }
            var something = (string)somethingOfSomething[1];
            Console.WriteLine(something);

            Console.ReadLine();
        }
    }
}
