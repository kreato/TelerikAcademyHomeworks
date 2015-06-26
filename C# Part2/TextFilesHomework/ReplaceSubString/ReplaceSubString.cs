//using System;Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).
namespace ReplaceSubString
{
    using System;
    using System.Text;
    using System.IO;
    class ReplaceSubString
    {
        static void Main()
        {
            using (StreamReader inputText = new StreamReader("../../InputText.txt", Encoding.UTF8))
            {
                using (StreamWriter outputText = new StreamWriter("../../OutputText.txt", true, Encoding.UTF8))
                {
                    while (true)
                    {
                        if (inputText.EndOfStream)
                        {
                            break;
                        }
                        string line = inputText.ReadLine();
                        string newLine = line.Replace("start","finish");
                        outputText.WriteLine(newLine);
                    }
                }
            }
            Console.WriteLine("Ready");
        }
    }
}