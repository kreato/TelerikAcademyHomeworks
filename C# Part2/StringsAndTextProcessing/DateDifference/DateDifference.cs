//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days
namespace DateDifference
{
    using System;
    using System.Linq;
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter first date (d.M.yyyy): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter second date (d.M.yyyy): ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            TimeSpan diff = date2 - date1;
            double numOfDays = diff.TotalDays;
            Console.WriteLine("Distance: {0} days",numOfDays);
        }
    }
}
