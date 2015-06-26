//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Linq;
class HexadecimalToDecimal
{
    static long ConvertHexadecimalToDecimal(string hexNumber)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            int digit = 0;
            if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
            {
                digit = hexNumber[i] - '0';
            }
            else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
            {
                digit = hexNumber[i] - 'A' + 10;
            }
            int position = hexNumber.Length - i - 1;
            decimalNumber += digit * (long)Math.Pow(16, position);
        }
        return decimalNumber;
    }
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNumber = Console.ReadLine().ToUpper();
        Console.WriteLine("Converted to decimal: {0}", ConvertHexadecimalToDecimal(hexNumber));
    }
}