//Problem 3. Day of week
//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
namespace DayOfWeek
{
    using System;
    using System.Linq;

    class DayOfWeek
    {
        static void Main()
        {
            DateTime td = DateTime.Now;
            string today = td.DayOfWeek.ToString();
            Console.WriteLine("Today is: {0}",today);
        }
    }
}
