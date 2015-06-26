//Problem 5. Workdays
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
namespace Workdays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Workdays
    {
        static List<DateTime> WorkingDays(DateTime end)
        {
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2015, 3, 3));
            holidays.Add(new DateTime(2015, 4, 10));
            holidays.Add(new DateTime(2015, 4, 13));
            holidays.Add(new DateTime(2015, 5, 1));
            holidays.Add(new DateTime(2015, 5, 6));
            holidays.Add(new DateTime(2015, 5, 24));
            holidays.Add(new DateTime(2015, 9, 6));
            holidays.Add(new DateTime(2015, 9, 22));
            holidays.Add(new DateTime(2015, 12, 24));
            holidays.Add(new DateTime(2015, 12, 25));
            
            DateTime date = DateTime.Now;
            List<DateTime> datesList = new List<DateTime>();
            while (date < end)
            {
                
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(date))
                {
                    datesList.Add(date);
                }
            
                date = date.AddDays(1.0);
            }
            return datesList;
        }
        static void Main()
        {
            Console.Write("Enter future date (d.m.yyyy): ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            var allDates = WorkingDays(end);
            var countOfWorkDays = allDates.Count();
            Console.WriteLine("There are {0} workdays till this date.",countOfWorkDays);
        }
    }
}
