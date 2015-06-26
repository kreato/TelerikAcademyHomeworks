//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
using System;
using System.Linq;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        static int GetSum(int[] arr)
        {
            return arr.Sum();
        }

        static decimal GetAverage(int[] arr)
        {
            return (decimal)GetSum(arr) / arr.Length;
        }

        static int GetProduct(int[] numbers)
        {
            return numbers.Aggregate(1, (current, t) => current * t);
        }
        static void Main()
        {
            Console.Write("Enter lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter index[{0}]: ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Minimum of set integers: {0}", GetMin(arr));
            Console.WriteLine("The Maximum of set integers: {0}", GetMax(arr));
            Console.WriteLine("The Sum of set integers: {0}", GetSum(arr));
            Console.WriteLine("The Average Sum of set integers: {0}", GetAverage(arr));
            Console.WriteLine("The Product of set integers: {0}", GetProduct(arr));
        }
    }
}