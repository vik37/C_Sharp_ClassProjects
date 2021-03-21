using System;


namespace MustHaveNumber
{
    public class HaveOneNumChar
    {
        public static bool CheckTherIsNum(string elOne)
        {

            char[] someArray = new char[] { };
            someArray = elOne.ToCharArray();

            
            for(int i = 0;i < someArray.Length;i++)
            {
                if (char.IsNumber(someArray[i]))                
                    return true;                
            }
            return false;
        }
    }
}
