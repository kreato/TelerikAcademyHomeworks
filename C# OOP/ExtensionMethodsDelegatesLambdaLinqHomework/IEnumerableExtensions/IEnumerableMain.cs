//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    public class IEnumerableMain
    {
        static void Main()
        {
            List<int> nums = new List<int> { 4, 3, 5, 2, 8, 10, 1, 7, 9, 6 };
            Console.WriteLine("Min number: {0}",nums.Min());
            Console.WriteLine("Max number: {0}",nums.Max());
            Console.WriteLine("Sum of numbers: {0}",nums.Sum());
            Console.WriteLine("Product of numbers: {0}",nums.Product());
            Console.WriteLine("Average of numbers: {0}",nums.Average());
        }
    }
}
