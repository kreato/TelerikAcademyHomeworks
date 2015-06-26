//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
using System;
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Is the third digit (right to left) 7?: {0}", (number / 100) % 10 == 7 && (number / 100) % 10 == 7);
    }
}