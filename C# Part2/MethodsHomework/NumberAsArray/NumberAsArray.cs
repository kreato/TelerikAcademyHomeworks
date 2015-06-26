//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static List<int> NumbertoArray(string number1, string number2)
        {

            var arr1 = number1.Select(ch => ch - '0').ToArray();
            var arr2 = number2.Select(ch => ch - '0').ToArray();

            Array.Reverse(arr1);
            Array.Reverse(arr2);
            List<int> result = new List<int>(Math.Max(arr1.Length, arr2.Length));
            int left = 0;

            for (int i = 0; i < result.Capacity; i++)
            {
                int num = (i < arr1.Length ? arr1[i] : 0) + (i < arr2.Length ? arr2[i] : 0) + left;
                left = num / 10;
                result.Add(num % 10);
            }

            if (left > 0) result.Add(left);
            return result;
        }
        static void Main()
        {
            Console.Write("Enter the first non-negative number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter the second non-negative number: ");
            string number2 = Console.ReadLine();

            List<int> result = NumbertoArray(number1, number2);
            Console.Write("Result: ");

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
