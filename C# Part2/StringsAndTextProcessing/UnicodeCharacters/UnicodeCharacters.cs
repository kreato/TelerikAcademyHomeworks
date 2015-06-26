//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
namespace UnicodeCharacters
{
    using System;
    using System.Linq;
    class UnicodeCharacters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            foreach (var item in text)
            {
                Console.Write(@"\u{0:X4}", (int)item);
            }
            Console.WriteLine();
        }
    }
}
