//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double formula = Math.Sqrt(b * b - 4 * a * c);
        double x1 = -b - formula;
        double x2 = -b + formula;
        Console.WriteLine("X1 = " + (x1 /= 2 * a));
        Console.WriteLine("X2 = " + (x2 /= 2 * a));
    }
}