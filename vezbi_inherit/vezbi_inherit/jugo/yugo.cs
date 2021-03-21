using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace vezbi_inherit.jugo
{
    class yugo
    {
        public string Name;
        public string Color;
        public DateTime date = DateTime.Now;
        public Class1 Tool { get; set; }
        public yugo()
        {
            
        }
        public yugo(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string myYugoCar()
        {
            return "My car" + Name + " is" + Color;
        }



    }
}
