using Helper;
using System;
using System.Collections.Generic;
using vezbiExerciseSvastaFirst.NewFolder.someClass;

namespace vezbiExerciseSvastaFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Inheritone();
            a.FirstName = "Krsto";
            a.LastName = "Praev";

            a.ShowId(21);
            a.WriteFool();
            Console.WriteLine(HelpClassLib.eden);
            Console.ReadLine();
        }
    }
}
