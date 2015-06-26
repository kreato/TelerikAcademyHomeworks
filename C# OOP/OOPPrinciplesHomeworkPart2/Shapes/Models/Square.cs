namespace Shapes.Models
{
    using System;

    public class Square : Shape
    {
        public Square(double shapeWidth, double shapeHeight)
            : base(shapeWidth, shapeHeight)
        {
            if (base.Width != base.Height)
            {
                throw new ArgumentException("Square's width must be equal to square's height");
            }
        }

        public override string CalculateSurface()
        {
            return string.Format("Square's surface: {0}",base.Height * base.Width);
        }
    }
}
