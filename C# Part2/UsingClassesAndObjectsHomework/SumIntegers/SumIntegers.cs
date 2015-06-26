//Problem 6. Sum integers
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
namespace SumIntegers
{
    using System;
    using System.Linq;
    class SumIntegers
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by space: ");
            string numbers = Console.ReadLine();
            int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var number in arr)
            {
                sum += number;
            }
            Console.WriteLine("The sum of these numbers is: {0}",sum);
        }
    }
}