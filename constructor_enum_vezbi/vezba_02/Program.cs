using System;
using vezba_02.Costumer;
using a.Ordher;


namespace vezba_02
{
    public class Something
    {
        public int Number;
        public string Animal;

        public Custumer();
      
        public Something()
        {

        }
        public Something(int number, string animal)
        {
            Number = number;
            Animal = animal;
        }

        public void NumberOfAnimal(int Number, string Animal )
        {
            Console.WriteLine($"This {Animal} numbers is {Number}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var custumer = new Custumer();
            custumer.Id = 1;
            custumer.Name = "John";
            Console.WriteLine(custumer.Id);
            Console.WriteLine(custumer.Name);

            var a = new ClassOrder();
            a.Age = 4;
            Console.WriteLine(a); ;
            Console.ReadLine();
        }
    }
}
