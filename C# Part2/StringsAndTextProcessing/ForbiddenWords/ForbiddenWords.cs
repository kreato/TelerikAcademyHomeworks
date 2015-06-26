//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
namespace ForbiddenWords
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ForbiddenWords
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("How many words do you wish to change?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter forbidden word {0}: ", i + 1);
                string word = Console.ReadLine();
                text = Regex.Replace(text, word, new string('*', word.Length));
            }
            Console.WriteLine("Result: {0}",text);
        }
    }
}