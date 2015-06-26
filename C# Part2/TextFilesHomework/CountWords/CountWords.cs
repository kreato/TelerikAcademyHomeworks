﻿//Problem 13. Count words
//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.
namespace CountWords
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Security;
    using System.IO;
    class CountWords
    {
        static void Main()
        {
            try
            {
                string[] listedWords = File.ReadAllLines("../../words.txt");
                int[] counter = new int[listedWords.Length];

                using (StreamReader reader = new StreamReader("../../test.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;

                        for (int index = 0; index < listedWords.Length; index++)
                        {
                            counter[index] += ((Regex
                                .Matches(line, @"\b" + listedWords[index] + @"\b").Count));
                        }

                        line = reader.ReadLine();
                    }
                }

                Array.Sort(counter, listedWords);

                using (StreamWriter writer = new StreamWriter("../../result.txt"))
                {
                    for (int index = listedWords.Length - 1; index >= 0; index--)
                    {
                        writer.WriteLine("{0}: {1}", listedWords[index], counter[index]);
                    }

                    Console.WriteLine("Ready");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}