//Problem 5. Formatting Numbers
//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
using System;
class FormatNumbers
{
    static void Main()
    {
        Console.Write("Enter first number (0 to 500): ");
        int firstNum = int.Parse(Console.ReadLine());
        if (firstNum >= 0 && firstNum <= 500)
        {
            string binary = Convert.ToString(firstNum, 2).PadLeft(10, '0');
            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}", firstNum, binary, secondNum, thirdNum);
        }
        else
        {
            Console.WriteLine("Not a valid number!");
        }
    }
}