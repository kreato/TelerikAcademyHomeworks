//Problem 11. Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
using System;
class ExtractBit3
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        uint num = uint.Parse(Console.ReadLine());
        int positionOFBit = 3;
        int mask = 1 << positionOFBit;
        long numAndMask = num & mask;
        long bit = numAndMask >> positionOFBit;
        Console.WriteLine("The third bit in this number is: " + bit + " ==> " + Convert.ToString(num, 2).PadLeft(18, '0'));
    }
}