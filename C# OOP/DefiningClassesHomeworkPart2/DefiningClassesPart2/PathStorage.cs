namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public static class PathStorage
    {
        public static void SavePath()
        {
            using (StreamWriter save = new StreamWriter("../../SavePath.txt"))
            {
                List<Point3D> sequenceOfPoints = new List<Point3D>();
                Path somePoints = new Path();
                somePoints.SequenceOfPoints(sequenceOfPoints);
                foreach (var item in sequenceOfPoints)
                {
                    save.WriteLine(item);
                }
            }
        }

        public static void LoadPath()
        {
            using (StreamReader load = new StreamReader("../../SavePath.txt"))
            {
                List<string> sequenceOfPoints = new List<string>();
                while (true)
                {
                    if (load.EndOfStream)
                    {
                        break;
                    }
                    string line = load.ReadLine();
                    sequenceOfPoints.Add(line);
                }
                foreach (var item in sequenceOfPoints)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
