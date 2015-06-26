//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static int MaxNumber(int[] arr, int index)
        {
            int maxNumber = arr[index];

            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }
            }
            return maxNumber;

        }
        static int[] SortedArray(int[] arr, int index)
        {
            var nextList = new List<int>();
            int count = 0;

            for (int i = index; i < arr.Length; i++)
            {
                nextList.Add(arr[i]);
                count++;
            }
            int[] nextArr = nextList.ToArray();
            Array.Sort(nextArr);
            return nextArr;
        }
        static void Main()
        {
            Console.Write("Enter lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int [n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter index[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Index : ");
            int index = int.Parse(Console.ReadLine());
            int result = MaxNumber(arr, index);
            Console.WriteLine("Max number from this index: {0}",result);
            int[] theArr = SortedArray(arr, index);
            Console.Write("Sorted: ");
            foreach (var item in theArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}