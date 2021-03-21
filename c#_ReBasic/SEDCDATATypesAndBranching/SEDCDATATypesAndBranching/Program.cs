using System;

namespace SEDCDATATypesAndBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variable and data types
            int number = 10;
            double decimalNumber = 10.5;
            char character = 'C';
            string words = "Hello there";
            float number1 = 6.3f;
            bool isRaining = false;

            Console.WriteLine(number);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(character);
            Console.WriteLine(words);

            int parsedNumber = int.Parse("22");
            #endregion
            Console.ReadLine();
        }
    }
}
