//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
using System;
class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter of the circle is: {0:F2}\r\nThe area of the circle is: {1:F2}",perimeter,area);
    }
}