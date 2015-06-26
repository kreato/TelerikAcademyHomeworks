//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
namespace SaveSortedNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    class SaveSortedNames
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader("../../Input.txt", Encoding.UTF8))
            {
                List<string> words = new List<string>();
                while (true)
                {
                    if (input.EndOfStream)
                    {
                        break;
                    }
                    string wordInLine = input.ReadLine();
                    words.Add(wordInLine);
                }
                var result =  words.OrderBy(x => x).ThenBy(x => x.Length);

                using (StreamWriter output = new StreamWriter("../../Output.txt",true, Encoding.UTF8))
                {
                    foreach (var word in result)
                    {
                        output.WriteLine(word);
                    }
                }
            }
            Console.WriteLine("Ready");
        }
    }
}
