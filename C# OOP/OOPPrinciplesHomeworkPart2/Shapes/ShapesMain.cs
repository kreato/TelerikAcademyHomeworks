namespace Shapes
{
    using Models;
    using System;
    using System.Collections.Generic;
    public class ShapesMain
    {
        static void Main()
        {
            List<Shape> someShapes = new List<Shape> 
            {
                new Triangle(4, 6),
                new Rectangle (8, 5),
                new Square(5, 5)
            };

            foreach (var shape in someShapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
