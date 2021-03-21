using Helper;
using System;
using System.Collections.Generic;
using System.Text;
using vezbiExerciseSvastaFirst.NewFolder.someClass;

namespace vezbiExerciseSvastaFirst.NewFolder
{
     public class ClassOne
    {
        private int Id;
        protected string Name;
        public string LastName;
        public ClassOne()
        {

        }
        public ClassOne(int id,string name,string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        public int IdontKnow(int num)
        {
            return Id = HelpClassLib.SomeNum(num) + 1;
        }
        public void ShowId(int num)
        {
            Console.WriteLine(num + IdontKnow(num));
        }
    }
}
