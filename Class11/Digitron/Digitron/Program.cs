
using System;
using System.Collections.Generic;
using Calculator.Models;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 40, 30, 50 };
            int maxNumber = Calc.Max(numbers);
            Console.WriteLine(maxNumber);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(Calc.Avg(numbers));

            // is a two-digit number EVEN or ODD
            Console.WriteLine("----------------------------------");
            foreach (var num in numbers)
            {
                Console.Write($"{num} --- ");
                if(Calc.EvenIs(num) == true)
                {
                    Console.WriteLine("EVEN");
                }
                else
                {
                    Console.WriteLine("ODD");
                }
                
                
            }
            Console.WriteLine("----------------------------------");
            // Duplicate List Numbers
            List<int> dupliNum = new List<int>();
            dupliNum = Calc.Duplicate(numbers);
            foreach(var dupli in dupliNum)
            {
                Console.WriteLine(dupli);
            }
            
            // Text numbers
            Console.WriteLine("----------------------------------");
            
            Calc.ShowTextNum(numbers);

            
            Console.ReadLine();
            
        }
    }
}
