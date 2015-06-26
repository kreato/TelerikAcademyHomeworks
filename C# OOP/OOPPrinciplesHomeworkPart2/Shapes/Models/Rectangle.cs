namespace Shapes.Models
{

    public class Rectangle : Shape
    {
        public Rectangle(double shapeWidth, double shapeHeight) 
            : base(shapeWidth, shapeHeight)
        {
        }

        public override string CalculateSurface()
        {
            return string.Format("Rectangle's surface: {0}",base.Height * base.Width);
        }
    }
}
