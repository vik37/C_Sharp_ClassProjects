using System;
using System.IO;

namespace InnerExceptionVezbi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int fN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    int sN = Convert.ToInt32(Console.ReadLine());

                    int result = fN / sN;
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\vikto\source\repos\ExceptionVezbi\InnerExceptionVezbi\Innerex.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine("Something Wrong === {0}", ex.Message);
                        sw.WriteLine(ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem. Please try again");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present",ex);
                    }



                }
            }
            catch(Exception except)
            {
                Console.WriteLine($"Inner Exception = {except.InnerException.GetType().Name}");
                if(except.InnerException != null)
                {
                    Console.WriteLine($"Current Exception = {except.GetType().Name}");
                }
                
                
            }
            Console.ReadLine();
        }
    }
}
