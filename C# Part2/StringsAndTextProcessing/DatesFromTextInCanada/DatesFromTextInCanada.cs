//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.Write("Enter text containing dates in format dd.MM.yyyy: ");
            string text = Console.ReadLine();
            var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
            Console.WriteLine("Extracted dates:");
            foreach (Match items in regex.Matches(text))
            {
                DateTime dt;
                if (DateTime.TryParseExact(items.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
                {
                    Console.WriteLine("{0: dd.MM.yyyy}", dt.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
                    
            }
        }
    }
}
