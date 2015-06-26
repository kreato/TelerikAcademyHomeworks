//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).
namespace ReplaceWholeWord
{
    using System;
    using System.Text;
    using System.IO;
    class ReplaceWholeWord
    {
        static void Main()
        {
            using (StreamReader inputText = new StreamReader("../../InputText.txt", Encoding.UTF8))
            {
                using (StreamWriter outputText = new StreamWriter("../../OutputText.txt",true, Encoding.UTF8))
                {
                    while (true)
                    {
                        if (inputText.EndOfStream)
                        {
                            break;
                        }
                        string line = inputText.ReadLine();
                        for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                        {
                            if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                            {
                                line = line.Insert(i, "finish").Remove(i + 6, 5);
                            }
                        }
                        outputText.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Ready");
        }
    }
}
