using System;

namespace Helper
{
    public static class HelpClassLib
    {
        public static string Nadimak = "Kec";
        public static int eden = 1;

        public static string ReturnFullName (string a,string b)
        {
            if (a.StartsWith("K"))
            {
                return $"FIRST NAME: {a} \n MIDDLE NAME: {Nadimak} \n  LAST NAME: {b}";
            }
            else
            {
                return $"FIRST NAME: {a} \n MIDDLE NAME: empty \n  LAST NAME: {b}";
            }
                
            
        }
        public static int SomeNum(int num)
        {
            num = num + 1 + 2;

            return num - 1;
        }
    }
}
