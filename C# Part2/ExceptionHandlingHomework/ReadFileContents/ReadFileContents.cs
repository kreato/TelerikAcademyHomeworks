using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader stream = new StreamReader(path))
                {
                    Console.WriteLine(stream.ReadToEnd());
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
