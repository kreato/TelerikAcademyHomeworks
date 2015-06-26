//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
using System.Linq;
class SortByStringLength
{
    static string[] SortedOS(string[] arr)
    {
        var result = arr.OrderBy(str => str.Length).ThenBy(str => str).ToArray();
        return result;
    }
    static void Main()
    {
        Console.Write("Enter lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter word [{0}]: ",i);
            array[i] = Console.ReadLine();
        }
        array = SortedOS(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}