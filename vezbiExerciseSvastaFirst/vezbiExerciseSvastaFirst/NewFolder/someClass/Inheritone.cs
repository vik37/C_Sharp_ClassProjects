using Helper;
using System;
using System.Collections.Generic;
using System.Text;
using vezbiExerciseSvastaFirst.NewFolder;

namespace vezbiExerciseSvastaFirst.NewFolder.someClass
{
    public class Inheritone : ClassOne
    {
        public string FirstName { get; set; }
        public Inheritone()
        {

        }
        public Inheritone(string firstName, int id, string name, string lastName) : base(id, name, lastName)
        {
            FirstName = firstName;
        }

        public void WriteFool()
        {
            Console.WriteLine(HelpClassLib.ReturnFullName(FirstName,LastName));
        }
        
    }
}
