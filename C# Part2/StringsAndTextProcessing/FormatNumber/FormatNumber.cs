﻿//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
namespace FormatNumber
{
    using System;
    using System.Linq;
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:D} Decimal number", number);
            Console.WriteLine("{0,15:X} Hexadecimal number", number);
            Console.WriteLine("{0,15:P} Percentage", number);
            Console.WriteLine("{0,15:E} Scientific Notation", number);
        }
    }
}