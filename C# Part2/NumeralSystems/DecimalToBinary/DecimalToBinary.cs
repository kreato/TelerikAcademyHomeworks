//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Linq;
class DecimalToBinary
{
    static string ConvertDecimalBinary(long decimalNumber)
    {
        string binaryNumber = string.Empty;
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 2;
            binaryNumber = digit + binaryNumber;
            decimalNumber /= 2;
        }
        return binaryNumber;
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Converted to binary: {0}", ConvertDecimalBinary(decimalNumber));
    }
}