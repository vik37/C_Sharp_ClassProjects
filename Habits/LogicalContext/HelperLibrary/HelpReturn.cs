using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalContext.HelperLibrary
{
    internal class HelpReturn
    {
        public static char[] Hiding(int a)
        {
            char[] arr = new char[] { '*' };
            int count = 0;
            while (count <= a)
            {
                if (arr.Length == a)
                {

                    return arr;
                }

                count++;
            }

            return arr;
        }

        
    }
}
