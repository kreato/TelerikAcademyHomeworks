using System;
class InsideOutside
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool insideK = (x - 1 * x - 1) + (y - 1 * y - 1) <= (1.5 * 1.5);
        bool outsideR = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        if (insideK == true && outsideR == false)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}