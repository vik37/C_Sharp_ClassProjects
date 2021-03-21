using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg (List<int> numbers)
        {
            return HelpersMethods.CalculateAverage(numbers);
        }
        public static int Max (List<int> numbers)
        {
            return HelpersMethods.FindMaxNumber(numbers);
        }
        public static bool EvenIs(int num)
        {
            return HelpersMethods.ReturneIsEven(num);
            
            
        }
        public static List<int> Duplicate(List<int> numbers)
        {
            
            return HelpersMethods.DuplicateListOfInt(numbers);
        }
        public static void ShowTextNum(List<int> numbers)
        {
            HelpersMethods.TextNum(numbers);
        }
        
    }
}
