using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("Enter n (n >= 0): ");
        int n = int.Parse(Console.ReadLine());
        BigInteger l = 2 * n;
        BigInteger m = n + 1;
        BigInteger fact2N = 1;
        BigInteger factNPlus1 = 1;
        BigInteger factN = 1;
        if (n < 0)
        {
            Console.WriteLine("Not a valid entry!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int j = 1; j <= l; j++)
            {
                fact2N *= j;
            }
            for (int k = 1; k <= m; k++)
            {
                factNPlus1 *= k;
            }
            Console.WriteLine("Nth catalan Number is: " + fact2N / (factNPlus1 * factN));
        }
    }
}