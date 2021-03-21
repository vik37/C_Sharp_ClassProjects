using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    public class UserLogger
    {
        private string FilePath { get; set; } = @"C:\Users\vikto\source\repos\Class15Prep\ExceptionHandling\ExceptionLogger.txt";
        public void LogException(Exception ex)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"{ex.GetType().Name}  {ex.Message} {ex.StackTrace}");
            sw.Close();
        }
    }
}
