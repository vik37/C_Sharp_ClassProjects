using System;
using System.Collections;

namespace non_generic_collect
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList SomeList = new ArrayList();
            SomeList.Add(200);
            SomeList.Add("I dont now what?");
            SomeList.Add(3.52);
            SomeList.Add(true);

            foreach (var item in SomeList)
            {
                Console.WriteLine(item);
            }

            var something = (decimal)SomeList[2];

            Console.WriteLine(something);
            Console.ReadLine();
        }
    }
}
