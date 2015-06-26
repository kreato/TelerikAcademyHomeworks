//Problem 4. Triangle surface
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.
namespace TriangleSurface
{
    using System;
    using System.Linq;

    class TriangleSurface
    {
        static decimal AreaBySideAndAltitude(decimal side, decimal altitude)
        {
            decimal result = (side * altitude) / 2;
            return result;
        }
        static double AreaByThreeSides(double sideA, double sideB, double sideC)
        {
            double p = (sideA + sideB + sideC) / 2;
            double result = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return result;
        }
        static double AreaByTwoSidesAndAngle(double sideA, double sideB, double angle)
        {
            double result = (sideA * sideB * Math.Sin(angle)) / 2;
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Choose a method:\r\nPress 1 to calculate the surface of a triangle by given side and height\r\nPress 2 to calculate the surface of a triangle by given three sides\r\nPress 3 to calculate the surface of a triangle by given two sides and an angle between them;");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter side A: ");
                        double sideA = double.Parse(Console.ReadLine());
                        Console.Write("Enter side B: ");
                        double sideB = double.Parse(Console.ReadLine());
                        Console.Write("Enter side C: ");
                        double sideC = double.Parse(Console.ReadLine());
                        Console.WriteLine("The result is: {0}", AreaByThreeSides(sideA, sideB, sideC));
                        break;
                    case 2: 
                        Console.Write("Enter side A: ");
                        double aSide = double.Parse(Console.ReadLine());
                        Console.Write("Enter side B: ");
                        double bSide = double.Parse(Console.ReadLine());
                        Console.Write("Enter the angle: ");
                        double angle = double.Parse(Console.ReadLine());
                        Console.WriteLine("The result is: {0}", AreaByTwoSidesAndAngle(aSide,bSide,angle));
                        break;
                    case 3:
                        Console.Write("Enter side: ");
                        decimal side = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter altitude: ");
                        decimal height = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("The result is: {0}",AreaBySideAndAltitude(side,height));
                        break;
                    default: Console.WriteLine("Not a valid entry!");
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Not a valid entry!");
            }    
        }
    }
}
