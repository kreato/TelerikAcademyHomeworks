//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
using System;
class Comparison
{
    static void Main()
    {
        bool result = false;
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());
        double comparison = Math.Abs(number1 - number2);
        Console.WriteLine(comparison);
        if (comparison < 0.000001)
        {
            result = true;
        }
        Console.WriteLine("({0};{1}) = {2}", number1, number2, result);
    }
}
