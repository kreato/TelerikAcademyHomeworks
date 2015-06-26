using System;
class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter end number: ");
        int endNum = int.Parse(Console.ReadLine());
        Console.Write("The numbers from 1 to end number: ");
        for (int startNum = 1; startNum <= endNum; startNum++)
        {
            Console.Write(startNum + " ");
        }
        Console.WriteLine();
    }
}