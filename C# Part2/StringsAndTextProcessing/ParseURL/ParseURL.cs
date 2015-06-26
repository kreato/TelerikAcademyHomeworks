//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
namespace ParseURL
{
    using System;
    using System.Linq;
    using System.Web;
    class ParseURL
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter URL: ");
                var url = new Uri(Console.ReadLine());
                Console.WriteLine("[Protocol]= {0}", url.Scheme);
                Console.WriteLine("[Server]= {0}", url.Host);
                Console.WriteLine("[Resource]= {0}", HttpUtility.UrlDecode(url.AbsolutePath));
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Not a valid URL");
            }
        }
    }
}