//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
namespace LettersCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LettersCount
    {
        static void Main()
        {
            char[] letters = Console.ReadLine().ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in letters)
            {
                if (!char.IsLetter(item))
                {
                    continue;
                }
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
                
            }
            Console.WriteLine("Letter occurence: \r\n{0}", string.Join("\n", dict.Select(x => string.Format(@"'{0}' ==> {1} times", x.Key, x.Value)).ToArray()));
        }
    }
}