//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
namespace StringBuilderSubstring
{
    using System;
    public class StringBuilderMain
    {
        static void Main()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello SKA people");
            var result = StringBuilder.Substring(sb, 6, sb.Length - 6);
            Console.WriteLine(result);
        }
    }
}