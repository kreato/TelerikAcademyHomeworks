namespace Gsm
{
    using System;
    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display()
        {

        }
        public Display(double displaySize, int displayColors)
        {
            this.Size = displaySize;
            this.NumberOfColors = displayColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 3)
                {
                    throw new ArgumentOutOfRangeException("Inavlid display size (should be greater than 3)");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 256000)
                {
                    throw new ArgumentOutOfRangeException("Inavlid display colors (should be greater than 256000)");
                }
                this.numberOfColors = value;
            }
        }
    }
}