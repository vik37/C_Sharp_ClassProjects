using System;
using System.Collections.Generic;

namespace GenericCollection
{
    public class Car
    {
        public int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var  sedcGroups = new List<string>() { "G1","G2","G3","G4","G5","G6","G7","G8"};
            //sedcGroups.Add("G1");
            //sedcGroups.Add(100)
            sedcGroups.AddRange(new List<string>() { "G9","G10"});
            foreach (var item in sedcGroups)
            {
                Console.WriteLine(sedcGroups);
            }
            Console.WriteLine($"The number of elements is: {sedcGroups.Count}");
            // DICTIONARY

            Dictionary<string, int> examPoints = new Dictionary<string, int>();
            examPoints.Add("Miodrag ", 50);
            examPoints.Add("Goce", 100);
            foreach (var item in examPoints)
            {
                Console.WriteLine(item.Key);
            }
            //var cars = new Dictionary<string, Car>();
            //cars.Add("SK1111AA",car1);


            // QUE
            var bankQueue = new Queue<string>();
            bankQueue.Enqueue("Buco");
            bankQueue.Enqueue("Ilija");
            bankQueue.Enqueue("Marija");

           var served = bankQueue.Dequeue();


            foreach (var item in bankQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Served is: " + served);

            var next = bankQueue.Peek();
            var sportBag = new Stack<string>();
            sportBag.Push("Trainers");
            sportBag.Push("T-Shirts");
            sportBag.Push("Jeans");

            sportBag.Pop();

            var equipment = sportBag.Peek();
            foreach (var item in sportBag)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
