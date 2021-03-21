using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime date = new DateTime();
            Console.WriteLine(date);

            var birthday = new DateTime(1982, 5, 26);
            Console.WriteLine(birthday);

            string date1 = "05/26/82";
            string date2 = "05.26.1982";
            string date3 = "05/26/1982 03:05:12";
            string date4 = "03-26-2020";
            string date5 = "mar.26.2020";
            Console.WriteLine("DATE TIME CONVERSION:");
            DateTime conversionDate3 = DateTime.Parse(date3);
            Console.WriteLine(conversionDate3);

            var today = DateTime.Now;
            Console.WriteLine(today);

            int day = today.Day;
            int month = today.Month;
            int year = today.Year;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            Console.WriteLine("Tomorrow is " + today.AddDays(1));
            Console.WriteLine("Yeasterday was: " + today.AddDays(-1).AddHours(1));

            string dateFormat = today.ToString("MM/dd/yyyy");
            Console.WriteLine(dateFormat);

            string dateFormatAnother = today.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormatAnother);
            Console.ReadLine();
        }
    }
}
