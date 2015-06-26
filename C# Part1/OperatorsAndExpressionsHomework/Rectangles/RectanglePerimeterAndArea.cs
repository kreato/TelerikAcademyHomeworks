//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;
class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter rectanle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter rectanle's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's perimeter is: " + (height + width) * 2 + "\n\rRectangle's area is: " + height * width);
    }
}