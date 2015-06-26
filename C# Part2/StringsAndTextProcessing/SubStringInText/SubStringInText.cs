//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9
namespace SubStringInText
{
    using System;
    using System.Linq;
    class SubStringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine().ToLower();
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();
            int index = text.IndexOf(keyword);
            int counter = 0;
            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword,index);
                index = text.IndexOf(keyword, index + 1);
                counter++;
            }
            Console.WriteLine("The result is: {0} times",counter);
        }
    }
}
