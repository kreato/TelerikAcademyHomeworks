//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
using System;
class Variables
{
    static void Main()
    {
        ushort firstNum = 52130;
        sbyte secondNum = -115;
        int thirdNum = 4825932;
        byte fourthNum = 97;
        short fifthNum = -10000;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", firstNum, secondNum, thirdNum, fourthNum, fifthNum);
    }
}