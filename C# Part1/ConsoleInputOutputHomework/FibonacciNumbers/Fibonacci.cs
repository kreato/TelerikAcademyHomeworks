//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
using System;
class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int n = int.Parse(Console.ReadLine());
        int x1 = 0;
        int x2 = 1;
        if (n == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        Console.Write("{0}, {1}, ", x1, x2);
        for (int i = 2; i < n; i++)
        {
            int x3 = x1 + x2;
            Console.Write(" {0}, ", x3);
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();
    }
}