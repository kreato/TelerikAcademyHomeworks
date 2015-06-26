//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
namespace LeapYear
{
    using System;
    using System.Linq;

    class LeapYear
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a year: ");
                int leapYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Is this a leap year?: {0}",DateTime.IsLeapYear(leapYear));
            }
            catch (Exception)
            {

                Console.WriteLine("Not a valid year!");
            }
            
        }
    }
}