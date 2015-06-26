//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
using System;
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        bool prime = true;
        int number = int.Parse(Console.ReadLine());
        if (number != 0 && number > 1)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            Console.WriteLine("Is this a prime number?: {0}", prime);
        }
        else
        {
            Console.WriteLine("Is this a prime number?: {0}", false);
        }

    }
}