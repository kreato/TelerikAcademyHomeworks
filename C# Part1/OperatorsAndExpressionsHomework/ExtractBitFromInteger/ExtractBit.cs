//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
class ExtractBit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Please enter position of bit: ");
        int positionOFBit = int.Parse(Console.ReadLine());
        int mask = 1 << positionOFBit;
        long numAndMask = num & mask;
        long bit = numAndMask >> positionOFBit;
        Console.WriteLine("The given position of the bit in this number is: " + bit + " ==> " + Convert.ToString(num, 2).PadLeft(18, '0'));
    }
}