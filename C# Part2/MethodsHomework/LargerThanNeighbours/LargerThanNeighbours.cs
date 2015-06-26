//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
using System;
class LargerThanNeighbours
{
    static bool IsLarger(int[] paramArr, int paramIndex)
    {
        if (paramIndex > 0 && paramIndex < paramArr.Length - 1)
        {
            if (paramArr[paramIndex - 1] < paramArr[paramIndex] && paramArr[paramIndex + 1] < paramArr[paramIndex])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (paramIndex == 0)
        {
            if (paramArr[paramIndex + 1] < paramArr[paramIndex])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        else if (paramIndex == paramArr.Length - 1)
        {
            if (paramArr[paramIndex - 1] < paramArr[paramIndex])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
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
        Console.Write("Enter index from the array: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the element greater than its neighbours?: {0}", IsLarger(arr, index));
    }
}