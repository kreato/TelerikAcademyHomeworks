using System;
class OddAndEvenProduct
{
    static void Main()
    {

        string[] numbers = Console.ReadLine().Split(' ');
        int counter = 1;
        int oddProduct = 1;
        int evenProduct = 1;

        foreach (var symbol in numbers)
        {
            if (counter % 2 != 0)
            {
                oddProduct *= Convert.ToInt32(symbol);

            }
            else
                evenProduct *= Convert.ToInt32(symbol);

            counter++;
        }
        Console.WriteLine(evenProduct);
        Console.WriteLine(oddProduct);
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("YES ! ");
        }
        else
            Console.WriteLine("NO ! ");
    }
}