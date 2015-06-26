//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
using System;
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of numbers: ");
        int number = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter a number: ");
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("The sum of these numbers is: {0}", sum);
    }
}