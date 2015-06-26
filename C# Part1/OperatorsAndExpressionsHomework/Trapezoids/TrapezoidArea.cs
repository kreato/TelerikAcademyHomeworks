//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
using System;
class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Please enter trapezoid's side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter trapezoid's side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter trapezoid's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area is: " + (sideA + sideB) * height / 2);
    }
}