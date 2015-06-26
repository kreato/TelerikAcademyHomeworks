//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
class PointInCircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool inside = (x * x) + (y * y) <= 2 * 2;
        Console.WriteLine("These coordinates are inside the circle = " + inside);
    }
}