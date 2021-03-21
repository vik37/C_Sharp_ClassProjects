using System;

namespace StaticKayword
{
    //public static class StaticClass
    //{
    //    public static int MyProperty { get; set; }
    //}
    public class Employee
    {
        static Employee()
        {
            Console.WriteLine("New instance is created from static constructor");
        }
        public Employee()
        {
            Console.WriteLine("New instance is created from default constructor");
            NumberOfEmplyees++;
        }
        public string Name { get; set; }
        public static int NumberOfEmplyees { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstEmployee = new Employee() { Name = "Miodrag" };
            var secondEmployee = new Employee() { Name = "Buco" };
            var thirthEmployee = new Employee() { Name = "Viktor" };
            Console.WriteLine(Employee.NumberOfEmplyees);
            Console.ReadLine();
        }
    }
}
