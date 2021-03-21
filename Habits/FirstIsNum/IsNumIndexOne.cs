using System;

namespace FirstIsNum
{
    public class IsNumIndexOne
    {
        public static bool CheckFirstIndex(string elOne)
        {

            char[] someArray = new char[] { };
            someArray = elOne.ToCharArray();
                        
                if (char.IsNumber(someArray[0]))
                {
                    return false;
                }

            return true;

        }
             


    }
}
