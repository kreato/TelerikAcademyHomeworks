//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:
//  a	    b	    c	    d	    e	    biggest
//  5	    2	    2	    4	    1	    5
//  -2	    -22	    1	    0	    0	    1
//  -2	    4	    3	    2	    0	    4
//  0	    -2.5	0	    5	    5	    5
//  -3	    -0.5	-1.1	-2	    -0.1	-0.1
using System;
class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        double biggest = 0;
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
        {
            biggest = firstNumber;
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
        {
            biggest = secondNumber;
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
        {
            biggest = thirdNumber;
        }
        else if (fourthNumber >= firstNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
        {
            biggest = fourthNumber;
        }
        else if (fifthNumber >= firstNumber && fifthNumber >= secondNumber && fifthNumber >= thirdNumber && fifthNumber >= fourthNumber)
        {
            biggest = fifthNumber;
        }
        Console.WriteLine("The biggest number is: " + biggest);
    }
}