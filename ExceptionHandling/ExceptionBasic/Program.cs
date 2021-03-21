using System;

namespace ExceptionBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for division");
            int result = 0;
            try
            {
                int number = int.Parse(Console.ReadLine());
                result = 10 / number;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong happend :(");
                //throw;
            }
            finally
            {
                Console.WriteLine("Im here FINALY");
            }
            

            //Console.WriteLine("Division of 10 with number is " + result);
            Console.WriteLine("Program continue... :)");

            Console.ReadLine();
        }
    }
}
