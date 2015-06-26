//Problem 14. Word dictionary
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
namespace WordDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");
            Console.Write("Enter key: ");
            string key = Console.ReadLine();
            Console.WriteLine(dict[key]);
        }
    }
}