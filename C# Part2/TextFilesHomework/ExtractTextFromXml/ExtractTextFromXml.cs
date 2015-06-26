//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.
namespace ExtractTextFromXml
{
    using System;
    using System.IO;
    class ExtractTextFromXml
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../xml.txt"))
            {
                string line = reader.ReadLine();
                string extract = string.Empty;
                while (line != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>')
                        {
                            while (line[i] != '<')
                            {
                                extract += line[i];
                                i++;
                            }
                            if (extract != "")
                            {
                                Console.WriteLine(extract.TrimStart(' '));
                                extract = "";
                            }
                        }
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
