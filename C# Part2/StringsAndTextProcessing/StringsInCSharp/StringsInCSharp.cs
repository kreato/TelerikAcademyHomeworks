//Problem 1. Strings in C#.
//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.
using System;
namespace StringsInCSharp
{
    class StringsInCSharp
    {
        static void Main()
        {
            Console.WriteLine("A string is a sequence of characters stored in a certain address in memory. In .NET Framework each character has a srtial number from the Unicode table. The class System.String enables us to handle strings in C#. The work with string facilitates us in manipulating the text content: construction of texts, text search and many other operations. The character sequences stored in a variable of the string class are never changing(immutable). After being assigned once, the content of the variable does not change directly - trying to change the value, it will be saved to a new location in the dynamic memory and the variable will point to it.");
        }
    }
}