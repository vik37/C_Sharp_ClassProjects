using System;

namespace strings_vezbi
{
    class Program
    {
        static void Main(string[] args)
        {
            string customAlignment = string.Format("| {0,10} | {1,10} |", "Id", "Order");
            Console.WriteLine(customAlignment);

            string ourString = "   We are learning, C# and it is FUN and EASY. Okay maybe, just FUN.    ";
            Console.WriteLine(ourString);
            string lowerCase = ourString.ToLower();
            Console.WriteLine(lowerCase);
            string upperCase = ourString.ToUpper();
            Console.WriteLine(upperCase);
            int ourLength = ourString.Length;
            Console.WriteLine(ourLength);
            string[] splited = ourString.Split('.');
            Console.WriteLine(splited[0]);
            bool startsWith = ourString.StartsWith("   W");
            Console.WriteLine(startsWith);
            int indexOfString = ourString.IndexOf("FUN");
            int nonExistingString = ourString.IndexOf("Nope");
            Console.WriteLine(indexOfString);
            Console.WriteLine(nonExistingString);
            string substring = ourString.Substring(5, 16);
            Console.WriteLine(substring);
            string trimmedString = ourString.Trim();
            Console.WriteLine(trimmedString);

            char[] chars = ourString.ToCharArray();
            Console.WriteLine(chars.Length);
            Console.WriteLine(chars[6]);
            // Two ways to turn char[] back to string
            Console.WriteLine(string.Join("", chars));
            Console.WriteLine(new string(chars));


            Console.ReadLine();
        }
    }
}
