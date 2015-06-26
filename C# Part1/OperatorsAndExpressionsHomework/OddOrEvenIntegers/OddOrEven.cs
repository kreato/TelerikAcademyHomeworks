//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.
using System;
class OddOrEven
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int Number = int.Parse(Console.ReadLine());
        if (((Number & 1) == 0))
        {

            Console.WriteLine("This number is even");

        }
        else
        {
            Console.WriteLine("This number is odd");
        }
    }
}