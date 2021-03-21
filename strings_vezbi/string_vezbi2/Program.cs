using System;

namespace string_vezbi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ourString = "   We are learning, C# and it is FUN and EASY. Okay maybe, just FUN.    ";
            string newString;
            newString = (String)ourString.Clone();

            Console.WriteLine(newString);

            string ourStringTwo = "  We are learning, C# and it is FUN and EASY. Okay maybe, just FUN.   ";
            //int compareString = ourString.CompareTo(ourStringTwo);
            //Console.WriteLine(compareString);
            //string firstname;
            //string lastname;


            //firstname = "Steven Clark";
            //lastname = "Clark";
            //Console.WriteLine(firstname.CompareTo(lastname));

            bool containsString = ourString.Contains("q");
            // contain() dali taa "bukva" ja ima vo zborot ili stringot i vraka boolean
            Console.WriteLine(containsString);
            bool equalString = ourString.Equals(ourStringTwo);
            Console.WriteLine(equalString);

            string insertStringWord = ourString.Insert(12,"Full curse C#.");
            Console.WriteLine(insertStringWord);
            // isert() e za vlez na nov text vo star string ima dva parametri(na prviot e brojot od koj index da pocnuva, vtoriot e tekstot sto ke vleze).

            bool normString = ourString.IsNormalized();
            Console.WriteLine("String is : {0}", ourString);
            Console.WriteLine("Is str1 string is in normalized form?: {0}",
                                                                normString);

            string removeSomeWords = ourString.Remove(20,30); // ima 2 parametri index koj zbor da se izbrise
            Console.WriteLine(removeSomeWords);
            Console.Write(@"\n\nFind maximum occurring character in a string :\n");
            Console.Write("Find maximum occurring character in a string :");
            Console.ReadLine();
        }
    }
}
