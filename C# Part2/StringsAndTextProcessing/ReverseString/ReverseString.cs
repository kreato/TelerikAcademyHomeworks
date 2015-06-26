//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.
namespace ReverseString
{
    using System;
    using System.Linq;
    using System.Text;
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length-1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            string reversedText = sb.ToString();
            Console.WriteLine("Reversed text: {0}",reversedText);
        }
    }
}