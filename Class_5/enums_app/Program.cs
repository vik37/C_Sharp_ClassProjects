using System;

namespace enums_app
{
    //C# Enumertaion (ENUM)
    public enum Days
    {
        Mondey = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {

           // if("")


            Console.WriteLine((int)Days.Saturday);
            Console.ReadLine();
        }
    }
}
