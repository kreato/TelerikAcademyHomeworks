//Problem 13. Reverse sentence
//Write a program that reverses the words in given sentence.
namespace ReverseSentence
{
    using System;
    using System.Linq;
    class ReverseSentence
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
        }
    }
}