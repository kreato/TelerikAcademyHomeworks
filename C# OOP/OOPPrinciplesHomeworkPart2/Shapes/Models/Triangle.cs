namespace Shapes.Models
{

    public class Triangle : Shape
    {
        public Triangle(double shapeWidth, double shapeHeight) 
            : base(shapeWidth, shapeHeight)
        {
        }

        public override string CalculateSurface()
        {
            return string.Format("Triangle's surface: {0}",base.Height * base.Width / 2);
        }
    }
}
