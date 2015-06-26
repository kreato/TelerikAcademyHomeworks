//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
class FirstLargerThanNeighbours
{
    static int IndexOfGreater(int[] paramArr)
    {
        int result = -1;
        for (int i = 1; i < paramArr.Length - 1; i++)
        {
            if (paramArr[i] > paramArr[i - 1] && paramArr[i] > paramArr[i + 1])
            {
                result = i;
                break;
            }
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter index [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Index of the first element greater than its neighbours: {0}", IndexOfGreater(arr));
    }
}