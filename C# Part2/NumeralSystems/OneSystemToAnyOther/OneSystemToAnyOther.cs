//Problem 7. One system to any other
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;
using System.Linq;
class OneSystemToAnyOther
{
    static string DecimalToBase(long decimalNumber, int numeralSystem)
    {
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            long digit = decimalNumber % numeralSystem;
            if (digit >= 0 && digit <= 9)
            {
                result = (char)(digit + '0') + result;
            }
            else
            {
                result = (char)(digit - 10 + 'A') + result;
            }
            decimalNumber /= numeralSystem;
        }
        return result;
    }
    static long BaseToDecimal(string number, int numeralSystem)
    {
        long decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = 0;
            if (number[i] >= '0' && number[i] <= '9')
            {
                digit = number[i] - '0';
            }
            else
            {
                digit = number[i] - 'A' + 10;
            }
            decimalNumber += digit * (long)Math.Pow(numeralSystem, number.Length - i - 1);
        }
        return decimalNumber;
    }

    static void Main()
    {
        Console.Write("Enter numeral system: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter base system: ");
        int b = int.Parse(Console.ReadLine());
        if (s == 10)
        {
            Console.Write("Enter decimal number: ");
            long decNumber = long.Parse(Console.ReadLine());
            if (b == 2)
            {
                Console.WriteLine("Converted to bynary: {0}", DecimalToBase(decNumber, b));
            }
            else if (b == 16)
            {
                Console.WriteLine("Converted to hexadecimal: {0}", DecimalToBase(decNumber, b));
            }

        }
        else if (b == 10)
        {
            if (s == 2)
            {
                Console.Write("Enter binary number: ");
            }
            else if (s == 16)
            {
                Console.Write("Enter hexadecimal number: ");
            }
            string baseSystem = Console.ReadLine().ToUpper();
            Console.WriteLine("Converted to decimal: {0}", BaseToDecimal(baseSystem, s));
        }
        else if (s == 16 && b == 2)
        {
            Console.Write("Enter hexadecimal number: ");
            string baseSystem = Console.ReadLine().ToUpper();
            Console.WriteLine(DecimalToBase(BaseToDecimal(baseSystem, s), b));
        }
        else if (s == 2 && b == 16)
        {
            Console.Write("Enter binary number: ");
            string baseSystem = Console.ReadLine();
            Console.WriteLine(DecimalToBase(BaseToDecimal(baseSystem, s), b));
        }
        else
        {
            Console.WriteLine("Choose 2, 10 or 16 for the systems");
        }
    }
}