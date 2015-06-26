//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
namespace SeriesOfLetters
{
    using System;
    using System.Linq;
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            try
            {
                Console.Write(text[0]);
                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i] != text[i - 1])
                    {
                        Console.Write(text[i]);
                    }
                }
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The input is empty");
            }
        }
    }
}