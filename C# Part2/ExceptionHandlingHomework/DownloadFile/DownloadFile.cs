//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;
using System.IO;
namespace DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter URL: ");
                string url = Console.ReadLine();
                Console.Write("Choose name of the output file: ");
                string name = Console.ReadLine();
                Console.Write("Choose format (mp3, txt, doc, pgn etc.) of the output file: ");
                string format = Console.ReadLine();
                Console.WriteLine("Downloading file. Please wait!");
                WebClient downloader = new WebClient();
                downloader.DownloadFile(url, name + "." + format);
                downloader.Dispose();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not a valid path!");
            }
            catch (WebException)
            {
                Console.WriteLine("Not a valid format!");
            }
            finally
            {
                Console.WriteLine("Ready! Go to: {0}",Directory.GetCurrentDirectory());
            }
        }
    }
}