//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a four digit number (1000 to 9999): ");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 100) % 10;
        int fourthDigit = (number / 1000) % 10;
        if (number >= 1000 && number <= 9999)
        {
            Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("Last digit infront: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
        else
        {
            Console.WriteLine("Not a valid four digit number!");
        }
    }
}
