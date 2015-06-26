namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0,0,0);


        public Point3D(int pointX, int pointY, int pointZ) 
            : this()
        {
            this.X = pointX;
            this.Y = pointY;
            this.Z = pointZ;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Z: {2}", this.X, this.Y, this.Z);
        }
    }
}
