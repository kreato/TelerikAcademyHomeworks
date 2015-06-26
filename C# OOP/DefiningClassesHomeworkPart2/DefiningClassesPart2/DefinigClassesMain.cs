namespace DefiningClassesPart2
{
    using System;
    [Version("1.0")]
    public class DefinigClassesMain
    {
        static readonly Random rnd = new Random();

        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            return second;
        }

        public static T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }
        static void Main()
        {
            Point3D firstPoint = new Point3D(6, 5, 4);
            Console.WriteLine("First point: {0}", firstPoint);

            Console.WriteLine("Second Point: {0}", Point3D.O);

            Console.WriteLine("Distance between 2 points: {0:F2}", DistanceBetween2Points.CalculateDistance(firstPoint, Point3D.O));

            PathStorage.SavePath(); // Saving random sequence of some points in text file.

            Console.WriteLine(new string('=', 42) + "\r\nLoaded sequnce of points from a saved file\r\n" + new string('=', 42));
            PathStorage.LoadPath(); // Loading the sequence from the saved file and printing it on the console.

            Console.WriteLine(new string('=', 48) + "\r\nTesting GenericList's Add function and Auto-Grow\r\n" + new string('=', 48));
            GenericList<Point3D> pointsInList = new GenericList<Point3D>();
            for (int i = 0; i < 10; i++)
            {
                pointsInList.Add(new Point3D(rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100)));
                Console.WriteLine("[Index: {0}] {1}", i, pointsInList[i]);
            }

            Console.WriteLine(new string('=', 37) + "\r\nTesting GenericList's Access function\r\n" + new string('=', 37));
            Point3D accessPoint = pointsInList.AccessElement(5);
            Console.WriteLine(accessPoint);

            Console.WriteLine(new string('=', 37) + "\r\nTesting GenericList's Remove function\r\n" + new string('=', 37));
            pointsInList.Remove(5);
            for (int i = 0; i < pointsInList.Count; i++)
            {
                Console.WriteLine("[Index: {0}] {1}", i, pointsInList[i]);
            }

            Console.WriteLine(new string('=', 39) + "\r\nTesting GenericList's InsertAt function\r\n" + new string('=', 39));
            pointsInList.InsertAt(new Point3D(32, 17, 98), 5);
            for (int i = 0; i < pointsInList.Count; i++)
            {
                Console.WriteLine("[Index: {0}] {1}", i, pointsInList[i]);
            }

            Console.WriteLine(new string('=', 49) + "\r\nTesting GenericList's FindIndexOfElement function\r\n" + new string('=', 49));
            var indexOf = pointsInList.FindIndexOfElement(new Point3D(32, 17, 98));
            Console.WriteLine("The index of {0} is: {1}", new Point3D(32, 17, 98), indexOf);

            Console.WriteLine(new string('=', 39) + "\r\nTesting GenericList's ToString function\r\n" + new string('=', 39));
            Console.WriteLine(pointsInList.ToString());

            Console.WriteLine(new string('=', 37) + "\r\nTesting Min<T>() and Max<T>() methods\r\n" + new string('=', 37));
            double distance1 = DistanceBetween2Points.CalculateDistance(pointsInList[0], pointsInList[1]);
            double distance2 = DistanceBetween2Points.CalculateDistance(pointsInList[2], pointsInList[3]);
            double min = Min<double>(distance1, distance2);
            double max = Max<double>(distance1, distance2);
            Console.WriteLine("Min distance: {0:F2}", min);
            Console.WriteLine("Max distance: {0:F2}", max);
            Console.WriteLine(new string('=', 20) + "\r\nTesting Mtarix class\r\n" + new string('=', 20));
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    firstMatrix[i, j] = (i + 3) + (j + 1) + 2;
                    secondMatrix[i, j] = (i + 1) + (j + 2);
                }
            }
            Console.WriteLine("First Matrix:\r\n{0}", firstMatrix);
            Console.WriteLine("Second Matrix:\r\n{0}", secondMatrix);
            Console.WriteLine(new string('=', 8) + "\r\nAddition\r\n" + new string('=', 8));
            Console.WriteLine("First Matrix + Second Matrix =\n{0}", firstMatrix + secondMatrix);
            Console.WriteLine(new string('=', 12) + "\r\nSubstraction\r\n" + new string('=', 12));
            Console.WriteLine("First Matrix - Second Matrix =\n{0}", firstMatrix - secondMatrix);
            Console.WriteLine(new string('=', 14) + "\r\nMultiplycation\r\n" + new string('=', 14));
            Console.WriteLine("First Matrix * Second Matrix =\n{0}", firstMatrix * secondMatrix);
            Console.WriteLine(new string('=', 13) + "\r\nTrue operator\r\n" + new string('=', 13));
            Matrix<int> anotherMatrix = new Matrix<int>(3, 3);
            Console.WriteLine("This matrix: ");
            if (anotherMatrix)
            {
                Console.WriteLine("{0}\r\ndoesn't containt zero elements", anotherMatrix);
            }
            else
            {
                Console.WriteLine("{0}\r\ncontaints zero elements", anotherMatrix);
            }

            object[] attributes = typeof(DefinigClassesMain).GetCustomAttributes(false);
            Console.WriteLine();
            Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
}