//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Linq;
class DecimalToHexadecimal
{
    static string ConvertDecimalToHexadecimal(long decimalNumber)
    {
        string hexadecimalNumber = string.Empty;
        while (decimalNumber > 0)
        {
            var digit = decimalNumber % 16;
            if (digit >= 0 && digit <= 9)
            {
                hexadecimalNumber = (char)(digit + '0') + hexadecimalNumber;
            }
            else if (digit >= 10 && digit <= 15)
            {
                hexadecimalNumber = (char)(digit - 10 + 'A') + hexadecimalNumber;
            }
            decimalNumber /= 16;
        }
        return hexadecimalNumber;
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Converted to hexadecimal: {0}", ConvertDecimalToHexadecimal(decimalNumber));
    }
}