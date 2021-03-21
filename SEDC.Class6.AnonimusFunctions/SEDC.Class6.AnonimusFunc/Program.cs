using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Class6.AnonimusFunc
{
    class Program
    {
        public static List<string> Name { get; set; } = new List<string>
        {
            "Bob",
            "Jill",
            "Wane",
            "Anna",
            "Greg",
            "John"
        };
        public static List<string> EmptyList { get; set; } = new List<string>();
        static void Main(string[] args)
        {
            Func<bool> isNameListEmpty = () => Name.Count == 0;
            Func<List<string>, bool> isListEmpty = (x) => x.Count == 0;

            //isListEmpty = (x) => !(x.Count > 0);

            Action<string> printAction = text => Console.WriteLine(text);
            Console.WriteLine($"{isListEmpty(Name)}");
            Console.WriteLine($"{isListEmpty(EmptyList)}");
            printAction($"isListEmpty {isNameListEmpty()}");

            Func<string, bool> isBobFount = (name) => name == "Bob";
            string findBob = Name.FirstOrDefault(isBobFount);
            var resault = Name.FirstOrDefault(name => name == "Anna");
            Console.WriteLine(resault);
            Console.ReadLine();
        }
       
    }
}
