//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
using System;
class ModifyАBit
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of the bit (1 or 0): ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number ==> " + Convert.ToString(num, 2).PadLeft(17, '0'));
        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = num & mask;
            Console.WriteLine("The result is: " + result + " Binary representation ==> " + Convert.ToString(result, 2).PadLeft(17, '0'));
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            int result = num | mask;
            Console.WriteLine("The result is: " + result + " - Binary representation ==> " + Convert.ToString(result, 2).PadLeft(17, '0'));
        }
        else
        {
            Console.WriteLine("Not a valid value!");
        }
    }
}