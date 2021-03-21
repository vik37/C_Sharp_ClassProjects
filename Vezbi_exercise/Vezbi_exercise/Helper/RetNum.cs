using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbi_exercise.Helper
{
    public class RetNum
    {
        public static int SomeNum(int number)
        {
            int num = 10;
            int count = 0;
            
            while(count < num)
            {
                number = count;
                count++;
            }
            return number;
        }
    }
}
