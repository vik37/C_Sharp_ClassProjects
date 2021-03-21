using System;

namespace ExceptipnsMultipleCatche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please be nice and enter number for byte");
            byte number = 0;
            try
            {
               number = byte.Parse(Console.ReadLine());

                throw new OverflowException("No such a contact");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (FormatException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Format exception ocurre");
            //    Console.WriteLine("You have text insteed number");
            //    throw;
            //}
            //catch (OverflowException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Overflow exception ocurre");
            //    Console.WriteLine("You have entered negative or bigger number then 255");
            //}
            //catch(ArgumentNullException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Argument exception ocurre");
            //    Console.WriteLine("You are trying to parse null");
            //    Console.ResetColor();
            //}
            Console.WriteLine("The value is  " + number);
            Console.ReadLine();

        }
    }
}
