//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.
namespace CompareTextFiles
{
    using System;
    using System.IO;
    class CompareTextFiles
    {
        static void Main()
        {
            StreamReader lines1 = new StreamReader("../../FirstFile.txt");
            StreamReader lines2 = new StreamReader("../../SecondFile.txt");
            int countLines = 0;
            int countSameLines = 0;
            int countDifferentLines = 0;
            while (true)
            {
                if (lines1.EndOfStream || lines2.EndOfStream)
                {
                    break;
                }
                countLines++;
                string lineTxt1 = lines1.ReadLine();
                Console.WriteLine("File 1 <line {0}>: {1}", countLines, lineTxt1);
                string lineTxt2 = lines2.ReadLine();
                Console.WriteLine("File 2 <line {0}>: {1}", countLines, lineTxt2);
                if (!lineTxt1.Equals(lineTxt2))
                {
                    countDifferentLines++;
                }
                else
                {
                    countSameLines++;
                }
            }
            lines1.Close();
            lines2.Close();
            Console.WriteLine("There are {0} different line(s) and {1} same line(s)", countDifferentLines, countSameLines);
        }
    }
}
