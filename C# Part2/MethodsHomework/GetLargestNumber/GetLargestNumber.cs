//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
using System;
class GetLargestNumber
{
    static double GetMax(double number1, double number2)
    {
        double max = number1;
        
        if (number2 > max)
        {
            max = number2;
        }

        return max;
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Biggest number is: {0}",GetMax(GetMax(a,b), c));
    }
}