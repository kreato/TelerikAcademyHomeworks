//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
class AppearanceCount
{
    static void CountOccurrences(int[] paramArr, int paramNum)
    {
        int counter = 0;

        foreach (var number in paramArr)
        {
            if (number == paramNum)
            {
                counter++;
            }
        }
        Console.WriteLine("This number occurs {0} times", counter);
    }
    static void Main()
    {
        Console.Write("Enter lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number from the array: ");
        int num = int.Parse(Console.ReadLine());
        CountOccurrences(arr, num);
    }
}