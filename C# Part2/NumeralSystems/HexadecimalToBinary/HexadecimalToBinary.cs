//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).
using System;
using System.Linq;
class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter hexademical number: ");
        string hexadecimalNumber = Console.ReadLine();
        string binaryNumber = Convert.ToString(Convert.ToInt64(hexadecimalNumber, 16), 2).ToUpper();
        Console.WriteLine("Converted to binary: {0}", binaryNumber);
    }
}