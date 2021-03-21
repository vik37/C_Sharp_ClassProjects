using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Threading;
using LogicalContext;
using LogicalContext.HelperLibrary;



namespace LogicalContext
{
    public class SomeContext
    {

        public static string getUp { get; private set; }

        public static char[] HidePass(int a)
        {
            return HelpReturn.Hiding(a);
        }
       
        public static string GetDate(int a, int b, int c, int d)
        {
            
            string three = Convert.ToString(a);
            string four = Convert.ToString(b);
            string five = Convert.ToString(c);
            string six = Convert.ToString(d);
            return $"day: {three} \\\n TIME:  {four} : {five} : {six}";
            //Console.WriteLine(result);
            // month: {two} year:,{three}

        }
        public static bool IfTwoNumbers(int numOne,int numTwo)
        {
            if((numOne == 1) || (numTwo == 2))
            {
                return true;
            }
            return false;
        }
    }
}
