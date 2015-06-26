//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.
namespace ConcatenateTextFiles
{
    using System;
    using System.IO;
    class ConcatenateTextFiles
    {
        static void Main()
        {
            try
            {
                string[] file1 = File.ReadAllLines("../../First File.txt");
                string[] file2 = File.ReadAllLines("../../Second File.txt");

                using (StreamWriter writer = File.CreateText("../../Output File.txt"))
                {
                    int lineNum = 0;
                    while (lineNum < file1.Length || lineNum < file2.Length)
                    {
                        if (lineNum < file1.Length)
                            writer.WriteLine(file1[lineNum]);
                        if (lineNum < file2.Length)
                            writer.WriteLine(file2[lineNum]);
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