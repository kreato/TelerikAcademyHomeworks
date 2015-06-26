using System;
class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Enter the number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            num[i] = int.Parse(Console.ReadLine());
            sum += num[i];
            average = (double)sum / n;
        }
        int min = num[0];
        int max = num[0];
        for (int j = 1; j < n; j++)
        {
            if (min > num[j])
            {
                min = num[j];
            }
            if (max < num[j])
            {
                max = num[j];
            }
        }
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("average={0:F2}", average);
    }
}