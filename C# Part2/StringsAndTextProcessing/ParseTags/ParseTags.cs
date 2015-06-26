//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
namespace ParseTags
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    class ParseTags
    {
        static string ModifyString(string s)
        {
            var tags = "<upcase>(.*?)</upcase>";
            string modified = Regex.Replace(s, tags, words => words.Groups[1].Value.ToUpper());
            return modified;
        }
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Result: {0}",ModifyString(text));
        }
    }
}