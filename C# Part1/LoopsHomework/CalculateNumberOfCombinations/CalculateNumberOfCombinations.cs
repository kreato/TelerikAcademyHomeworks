using System;
using System.Numerics;
class CalculateNumberOfCombinations
{
    static void Main()
    {
        Console.Write("Enter n (2 - 100): ");
        BigInteger n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (1 - 100): ");
        BigInteger k = int.Parse(Console.ReadLine());
        BigInteger m = n - k;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        BigInteger numOfComb = 1;
        if (n <= k || n < 1 || k < 1 || n > 100 || k > 100)
        {
            Console.WriteLine("Not a valid entry!");
        }
        else
        {
            for (int i = 1, l = 1; i <= n || l <= m; i++, l++)
            {
                if (l <= m)
                {
                    factorialN *= i;
                    factorialNK *= l;
                }
                else
                {
                    factorialN *= i;
                }
            }
            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }
            numOfComb = factorialN / (factorialK * factorialNK);
            Console.WriteLine(numOfComb);
        }
    }
}