using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Helpers
{
    internal static class HelpersMethods
    {
        internal static decimal CalculateAverage(List<int> numbers)
        {
            int sum = 0;
            numbers.ForEach(number => sum += number);
            return Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Count);
        }

        internal static int FindMaxNumber (List<int>numbers)
        {
            int max = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
        internal static bool ReturneIsEven(int i)
        {

            return i % 20 == 0;
            
        }
        internal static List<int> DuplicateListOfInt(List<int> numbers)
        {
            int count = 0;
            var result = new List<int>();
            for(int i = 0; i < numbers.Count; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        result.AddRange(numbers);
                        
                    }
                    count++;
                }
            }
            return  result;      
         }
        internal static void TextNum(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num == 10)
                {
                    Console.WriteLine($"ten ---- {num}");
                }
                else if (num == 20)
                {
                    Console.WriteLine($"twenthy ---- {num}");
                }
                else if (num == 30)
                {
                    Console.WriteLine($"thirty ---- {num}");
                }
                else if (num == 40)
                {
                    Console.WriteLine($"forty ----- {num}");
                }
                else if(num == 50)
                {
                    Console.WriteLine($"fifty ----- {num}");
                }
                else
                {
                    Console.WriteLine("no more numbers");
                }
            }
        }
    }
}
