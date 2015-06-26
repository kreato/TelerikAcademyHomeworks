//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.
namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;
    class LineNumbers
    {
        static void Main()
        {
            try
            {
                string[] file = File.ReadAllLines("../../Text File.txt", Encoding.UTF8);

                using (StreamWriter writer = File.CreateText("../../Output File.txt"))
                {
                    int lineNum = 0;
                    while (lineNum < file.Length)
                    {
                        if (lineNum < file.Length)
                        {
                            writer.WriteLine("Line {0}: {1}", lineNum + 1, file[lineNum]);
                        }
                        lineNum++;
                    }
                }
            }
            finally
            {

                Console.WriteLine("Ready");
            }
        }
    }
}