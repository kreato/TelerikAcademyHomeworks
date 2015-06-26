//Problem 14.* Print the ASCII Table
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the consol(characters from 0 to 255).
using System;
class ASCIITable
{
    static void Main()
    {
        for (int symbol = 0; symbol <= 255; symbol++)
        {
            Console.WriteLine((char)symbol);
        }
    }
}