namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        readonly Random rnd = new Random();
        public void SequenceOfPoints(List<Point3D> sequenceOfPoints)
        {
            for (int i = 0; i < 5; i++)
            {
                sequenceOfPoints.Add(new Point3D(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100)));
            }
        }
    }
}
