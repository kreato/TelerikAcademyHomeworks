//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;
class DivisionWithoutReminder
{
    static void Main()
    {
        Console.Write("Please enter a number that can be divided by 7 and 5: ");
        int num = int.Parse(Console.ReadLine());
        if (num != 0)
        {
            Console.WriteLine("The result is: " + (num % 7 == 0 && num % 5 == 0));
        }
        else
        {
            Console.WriteLine("The result is: " + false);
        }
    }
}