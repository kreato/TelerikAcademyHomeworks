//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.
using System;
using System.Linq;
using System.Text;
class ReverseNumber
{
    static decimal ReversedNumber(decimal paramNum)
    {
        string decimalToString = paramNum.ToString();
        StringBuilder reversed = new StringBuilder();
        for (int i = decimalToString.Length - 1; i >= 0; i--)
        {
            reversed.Append(decimalToString[i]);
        }
        string reversedString = reversed.ToString();
        decimal reversedDecimal = Convert.ToDecimal(reversedString);
        return reversedDecimal;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal num = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number: {0}", ReversedNumber(num));
    }
}