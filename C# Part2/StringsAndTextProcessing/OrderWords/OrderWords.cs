//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
namespace OrderWords
{
    using System;
    using System.Linq;
    class OrderWords
    {
        static void Main()
        {
            Console.Write("Enter words: ");
            string words = Console.ReadLine();
            var result = words.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(result);
            Console.WriteLine("Words sorted in alphabetical order:\n{0}", string.Join("\n", result.Select(x => string.Format("{0}", x))));
        }
    }
}