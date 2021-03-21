using System;

namespace vezbi_array_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a new array of integers with 5 elements
            //int[] numbers = new int[5];

            //int numberOfElement = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numberOfElement = i + 1;

            //    Console.WriteLine("enter the " + numberOfElement + " numbers");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.ReadLine();

            //int suma = 0;

            //foreach (var num in numbers)
            //{
            //    suma += num;
            //}
            //Console.WriteLine(suma);
            //Console.ReadLine();

            //int[] numbers = new int[2];


            //numbers[0] = 10;
            //numbers[1] = 20;

            //int[] errorNum = new int[2] { 10, 20 };

            //errorNum[1] = 123;
            //Console.WriteLine(numbers[1]);
            //Console.ReadLine();

            // int[] array = new int[] { 1, 2, 3, 4, 5 };

            //int indexOfTwo = Array.IndexOf(array, 2);

            //Console.WriteLine(indexOfTwo);
            //Console.ReadLine();

            //Array.Reverse(array);
            //foreach (var number in array)
            //{

            //    Console.Write(number);
            //    Console.ReadLine();
            //}

            //int[] clonedArray = new int[5];
            //Array.Copy(array, clonedArray, 5);
            //foreach (var number in clonedArray)
            //{

            //    Console.Write(number);
            //    Console.ReadLine();
            //}

            int[] someNum = new int[] { 8, 3, 5, 9, 1, 23, 67, 12 };
            Array.Sort(someNum);

            foreach (var number in someNum)
            {

                Console.Write(number);
                Console.ReadLine();
            }


        }
    }
}
