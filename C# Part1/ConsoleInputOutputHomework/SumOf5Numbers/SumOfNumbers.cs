//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers (in a single line and separated by a space)");
        string[] numbers = Console.ReadLine().Split();
        double firstNum = double.Parse(numbers[0]);
        double secondNum = double.Parse(numbers[1]);
        double thirdNum = double.Parse(numbers[2]);
        double fourthNum = double.Parse(numbers[3]);
        double fifthNum = double.Parse(numbers[4]);
        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", firstNum, secondNum, thirdNum, fourthNum, fifthNum, firstNum + secondNum + thirdNum + fourthNum + fifthNum);
    }
}