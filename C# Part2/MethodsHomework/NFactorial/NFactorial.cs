//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].
using System;
using System.Linq;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger Factorial(int number)
        {
            BigInteger factrorial = 1;
            int counter = 1;
            for (int i = 0; i < 100; i++)
            {
                factrorial *= counter;
                if (number == counter)
                {
                    break;
                }
                counter++;
            }
            return factrorial;
        }
        static void Main()
        {
            Console.Write("Enter a number in the range 1 - 100: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Not a valid input!");
                return;
            }
            var result = Factorial(num);
            Console.WriteLine("{0}! = {1}", num, result);
        }
    }
}