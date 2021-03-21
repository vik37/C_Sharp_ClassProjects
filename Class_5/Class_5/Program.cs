using System;

namespace Class_5
{
    class Program
    {
        static void Main(string[] args)
        {


            string groupFeedback = "C# is GREAT programming language";

            Console.WriteLine($@"The length of {groupFeedback} ""STRING"" is: {groupFeedback.Length}");


            string gitUserName = "      vik_37        ";
            Console.WriteLine("GIT Username: " + gitUserName.Length);

            string gitUsernameTrimmed = gitUserName.Trim();
            Console.WriteLine($"Git username length with trim() is: {gitUsernameTrimmed.Length}");

            string academySubject = "HTML, CSS, JavaScript, C#";

            bool htmlIsFirstSubject = academySubject.StartsWith("HTML");
            bool cSharpIsCurrentSubject = academySubject.EndsWith("C#");
            var indexOfJavaScript = academySubject.IndexOf("Java Script");

            Console.WriteLine($"THML is: {htmlIsFirstSubject}, C# {cSharpIsCurrentSubject}, Java Script with index {indexOfJavaScript}");

            Console.ReadLine();

        }
    }
}
