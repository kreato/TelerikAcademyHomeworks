//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
namespace ExtractTextFromHtml
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class HtmlTagRemover
    {
        private const string InputFileName = @"../../Problem25.html";

        static void Main()
        {
            if (!File.Exists(InputFileName))
            {
                Console.WriteLine(
                    "File " + InputFileName + " not found.");
                return;
            }

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(InputFileName);
            
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = RemoveAllTags(line);
                    line = RemoveDoubleNewLines(line);
                    line = TrimNewLines(line);
                    if (!string.IsNullOrEmpty(line))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine(
                    "Can not read file " + InputFileName + ".");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private static string RemoveAllTags(string str)
        {
            string strWithoutTags =
                Regex.Replace(str, "<[^>]*>", "\n");
            return strWithoutTags;
        }

        private static string RemoveDoubleNewLines(string str)
        {
            string pattern = "[\n]+";
            return Regex.Replace(str, pattern, "\n");
        }

        private static string TrimNewLines(string str)
        {
            int start = 0;
            while (start < str.Length && str[start] == '\n')
            {
                start++;
            }

            int end = str.Length - 1;
            while (end >= 0 && str[end] == '\n')
            {
                end--;
            }

            if (start > end)
            {
                return string.Empty;
            }

            string trimmed = str.Substring(start, end - start + 1);
            return trimmed;
        }
    }
}