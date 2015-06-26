using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string newText = text.Replace(@"<a href=""", "[URL=")
                                 .Replace(@""">", "]")
                                 .Replace("</a>", "[/URL]");
            Console.WriteLine(newText);
        }
    }
}
