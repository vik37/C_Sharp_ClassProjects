using System;

namespace class0104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ONLINE World!");

            //int firstNumber = 10;
            //int secondNumber = 20;
            //int thirdNumber = 100;
            //var[] numbers = new var[] { 10, 20, 30, 50, 80 };
            //int sumOfAll = Sum(numbers);
            //Console.WriteLine(SumOfAll);
            //int result = Sum(firstNumber, secondNumber);
            //int anotherResult = Sum(firstNumber, secondNumber, thirdNumber);
            //Console.WriteLine("The sum of number is: " + result);

            

            Console.ReadLine();
        }
        public static int Sum(int first, int second)
        {
            var result = first + second;
            return result;
        }

        public static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;

            }
            return sum;
        }
    }
}
