//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
//Examples:
//  a	    b	    c	    result
//  5	    1	    2	    5 2 1
//  -2	    -2	    1	    1 -2 -2
//  -2	    4	    3	    4 3 -2
//  0	    -2.5	5	    5 0 -2.5
//  -1.1	-0.5	-0.1	-0.1 -0.5 -1.1
//  10	    20	    30	    30 20 10
//  1	    1	    1	    1 1 1
using System;
class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (thirdNumber > firstNumber)
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber)
        {
            Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
        }
    }
}