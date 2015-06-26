//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;
using System.Linq;
class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter decimal number (-32768 to 32767): ");
        try
        {
            short number = short.Parse(Console.ReadLine());
            string result = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine("Converted to binary: {0}", result);
        }
        catch (Exception)
        {
            Console.WriteLine("Not a valid short number!");
        }
    }

}