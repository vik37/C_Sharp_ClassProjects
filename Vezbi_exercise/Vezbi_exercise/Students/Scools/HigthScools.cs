using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbi_exercise.Students.Scools
{
    public class HigthScools
    {
        public string NamesScool { get; set; }
        public int Classes { get; set; }
        public string Teachers { get; set; }
        public HigthScools()
        {

        }
        public HigthScools(string namesScool, int classes, string teachers)
        {
            NamesScool = namesScool;
            Classes = classes;
            Teachers = teachers;
        }
    }
}
