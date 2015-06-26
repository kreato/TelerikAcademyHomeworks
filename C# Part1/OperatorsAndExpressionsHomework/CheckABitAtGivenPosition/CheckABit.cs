//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
using System;
class CheckABit
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
        Console.WriteLine("The bit of the given position has value of 1: " + (bit == 1 & bit != 0) +  " ==> " + Convert.ToString(num, 2).PadLeft(18, '0'));
    }
}