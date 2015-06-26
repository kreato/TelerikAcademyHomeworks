//Problem 20. Palindromes
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
namespace Palindromes
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    class Palindromes
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            var result = Regex.Matches(text, @"\w+").Cast<Match>()
                    .Select(m => m.Value)
                    .Where(w => String.Join("", w.Reverse()) == w)
                    .GroupBy(w => w)
                    .Select(g => new {Palindrome = g.Key})
                    .ToList();
            Console.WriteLine("Result:");
            result.ForEach(Console.WriteLine);
        }
    }
}