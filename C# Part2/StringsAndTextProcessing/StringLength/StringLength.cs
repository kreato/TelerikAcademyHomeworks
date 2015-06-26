//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.
namespace StringLength
{
    using System;
    using System.Linq;
    class StringLength
    {
        static void Main()
        {
            Console.Write("Enter text (maximum 20 characters: )");
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
                Console.WriteLine("The text should be maximum 20 characters");
                return;
            }
            string result = text.PadRight(20, '*');
            Console.WriteLine(result);
        }
    }
}