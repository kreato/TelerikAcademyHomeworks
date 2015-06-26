namespace Shapes.Models
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double shapeWidth, double shapeHeight)
        {
            this.Width = shapeWidth;
            this.Height = shapeHeight;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }

        public abstract string CalculateSurface();
    }
}
