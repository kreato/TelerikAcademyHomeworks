//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.
using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}",firstNum,secondNum,thirdNum,firstNum + secondNum + thirdNum);
    }
}
