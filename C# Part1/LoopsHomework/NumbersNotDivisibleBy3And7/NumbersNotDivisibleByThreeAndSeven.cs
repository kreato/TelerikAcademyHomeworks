using System;
class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Enter end number: ");
        int endNum = int.Parse(Console.ReadLine());
        int startNum = 1;
        Console.Write("The numbers from 1 to end number, not divisible by 3 and 7: ");
        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}