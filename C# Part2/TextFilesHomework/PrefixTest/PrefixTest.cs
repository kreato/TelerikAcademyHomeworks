//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.
namespace PrefixTest
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    class PrefixTest
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader("../../InputText.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../OutputText.txt"))
                {
                    string line = input.ReadLine();

                    while (line != null)
                    {
                        output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                        line = input.ReadLine();
                    }
                }
            }
            Console.WriteLine("Ready");
        }
    }
}