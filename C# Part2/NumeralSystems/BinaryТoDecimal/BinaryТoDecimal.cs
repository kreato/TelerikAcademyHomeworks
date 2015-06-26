//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Linq;
class BinaryТoDecimal
{
    static long ConvertBinaryToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] - '0';
            int position = binaryNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(2, position);
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNum = Console.ReadLine();
        Console.WriteLine("Converted to decimal: {0}", ConvertBinaryToDecimal(binaryNum));
    }
}