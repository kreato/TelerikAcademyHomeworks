//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
namespace RandomNumbers
{
    using System;
    using System.Linq;
    class RandomNumbers
    {
        static void Main()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            Console.Write("10 random numbers in range (100 - 200): ");
            for (int i = 0; i < 10; i++)
            {
                int randomInt = rnd.Next(100, 201);
                Console.Write(randomInt);
                if (i == 9)
                {
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}