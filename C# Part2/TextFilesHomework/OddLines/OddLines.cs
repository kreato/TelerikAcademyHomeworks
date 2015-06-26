//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../Bez resto.txt", Encoding.UTF8))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();

                while (line!=null)
                {
                    lineNumber++;
                    if (lineNumber%2!=0)
                    {
                        Console.WriteLine("Line {0}: {1}",lineNumber,line);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}
