//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element [{0}]: ",i);
            arr[i] = int.Parse(Console.ReadLine());

        }
        Array.Sort(arr);
        var result = arr.Where(x => x <= k).ToArray();
        Console.WriteLine("The number from the array which is <= {0} is: {1}",k,result.Max());
    }
}
