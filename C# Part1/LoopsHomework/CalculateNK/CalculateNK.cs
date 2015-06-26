using System;
using System.Numerics;
class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter n (2 - 100): ");
        BigInteger n = int.Parse(Console.ReadLine());
        Console.Write("Enter k (1 - 100): ");
        BigInteger k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger division = 0;
        if (n < k || n < 1 || k < 1 || n > 100 || k > 100)
        {
            Console.WriteLine("Not a valid entry");
        }
        else
        {
            for (int i = 1, j = 1; i <= n || j <= k; i++, j++)
            {
                if (j <= k)
                {
                    factorialN *= i;
                    factorialK *= j;
                }
                else if (j > k)
                {
                    factorialN *= i;
                }
                division = factorialN / factorialK;

            }
            Console.WriteLine(division);
        }  
    }
}