using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRV NACIN
            try
            {
                Console.WriteLine("Please enter numerator");
                int numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter denominator");
                int denominator = int.Parse(Console.ReadLine());
                int result = numerator / denominator;
                Console.WriteLine("Result is equal to {0}", result);
            }
            
            catch (FormatException)
            {
                Console.WriteLine("ERROR --- Please enter number");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"Only numbers between {int.MinValue} and {int.MaxValue} are allowed ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero is not allowed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // VTOR NACIN
            //try
            //{
            //    Console.WriteLine("Please enter numerator");
            //    int numerator;
            //    bool isNumeratorAvalible = int.TryParse(Console.ReadLine(), out numerator);
            //    if (isNumeratorAvalible)
            //    {
            //        Console.WriteLine("Please enter denominator");
            //        int denominator;
            //        bool isDominatorAvalible = int.TryParse(Console.ReadLine(), out denominator);
            //        if (isDominatorAvalible && denominator != 0)
            //        {
            //            int result = numerator / denominator;
            //            Console.WriteLine("Result is equal to {0}", result);
            //        }
            //        else
            //        {
            //            if (denominator == 0)
            //            {
            //                Console.WriteLine("Denominator can not be zero");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Denominator should be a valid number between {int.MinValue} and {int.MaxValue}");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Numerator should be a valid number between {int.MinValue} and {int.MaxValue}");
            //    }

            //}           
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
        }
    }
}
