//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class DivisibleBy7And3Main
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 500; i++)
            {
                numbers.Add(i);
            }
            var firstResult = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            Console.WriteLine("extension method:");
            Console.WriteLine("Numbers from 1 to 500 that are divisible by 7 and 3 at the same time:");
            Console.WriteLine(string.Join(", ", firstResult));

            var secondResult =
                from number in numbers
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("LINQ:");
            Console.WriteLine("Numbers from 1 to 500 that are divisible by 7 and 3 at the same time:");
            Console.WriteLine(string.Join(", ", secondResult));
        }
    }
}
