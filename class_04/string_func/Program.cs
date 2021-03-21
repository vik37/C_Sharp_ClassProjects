using System;

namespace string_func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are starting with strings: (:");
            string academy = "Seavus Education and Developing Centar";
            string academyAcronym = "SEDC";

            //string academyTitle = academyAcronym + " " + "-" + " " + academy;

            Console.WriteLine("{0} - {1}", academy, academyAcronym);
            
            string academyTitle = string.Format("{0} - {1}", academy, academyAcronym);
              Console.WriteLine(academyTitle);

            float price = 150.28f;
            string currency = string.Format("{0:C}", price);
            Console.WriteLine(currency);
            float part = 0.5f;
            string percent = string.Format("{0:P}", part);
            Console.WriteLine(percent);

            var mobileNumber = 38970111222;
            string mobileNumberFency = string.Format("{0:(###) ## ###-###}", mobileNumber);
            Console.WriteLine(mobileNumberFency);

            string group = "G1";
            string behaviour = "Rocks!";

            string what = $"{group} are amazing! The group {behaviour}";
            Console.WriteLine(what);


            Console.ReadLine();
        }
    }
}
