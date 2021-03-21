using System;
using System.Collections.Generic;
using System.Text;
using vezbi_inherit.jugo;

namespace vezbi_inherit.audi
{
    class audi : yugo
    {
        
        public string Type;
        public audi(string type, string name,string color) 
            : base(name, color)
        {
            Type = type;
            Name = name;
            Color = color;

            
        }

        public void thisCar()
        {
            Console.WriteLine("Name - {0}, Color - {1}, Type - {2}");
        }
    }
}
