//Problem 12. Remove words
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.
namespace RemoveWords
{

    using System;
    using System.Text.RegularExpressions;
    using System.IO;
    using System.Security;
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string listOfForbidenWords = @"\b" + String.Join("|",
                    File.ReadAllLines("../../ListOfForbiddenWords.txt")) + @"\b";

                using (StreamReader readText = new StreamReader("../../Text.txt"))
                {
                    using (StreamWriter printResult = new StreamWriter("../../Result.txt"))
                    {
                        string line = readText.ReadLine();

                        while (!readText.EndOfStream)
                        {

                            printResult.WriteLine(Regex.Replace(line, listOfForbidenWords , String.Empty));

                            line = readText.ReadLine();
                        }

                        Console.WriteLine("Ready");
                    }
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