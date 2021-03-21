using System;
using System.IO;

namespace ExceptionVezbi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string myFile = @"C:\Users\vikto\source\repos\ExceptionVezbi\some\siluvanje.txt.txt";
            //try
            //{

            //    StreamReader sw = new StreamReader(myFile);
            //    Console.WriteLine(sw.ReadToEnd());
            //    sw.ReadLine();
            //    sw.Close();

            //}
            //catch (Exception ex)
            //{
            //    StreamWriter sr = new StreamWriter(myFile);
            //    sr.WriteLine(ex.Message);
            //    sr.Close();
            //    Console.WriteLine(ex.Message);
            //}
            StreamReader sw = null;
            try
            {
               sw = new StreamReader(@"C:\Users\vikto\source\repos\ExceptionVezbi\some\siluvane.txt");
                Console.WriteLine(sw.ReadToEnd());
                
                
            }
            catch (FileNotFoundException ex)
            {
                
                Console.WriteLine(ex.FileName);
                Console.WriteLine("---------------");
                Console.WriteLine("---------------");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                
                Console.WriteLine("Please check path file {0}",ex.Message);
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                    Console.WriteLine("Finaly Block");
                }
               
                
            }
            Console.WriteLine("Program Continue....");
            Console.ReadLine();
        }
    }
}
