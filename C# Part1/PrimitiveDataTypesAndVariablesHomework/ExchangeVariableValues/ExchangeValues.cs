//Problem 9. Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
using System;
class ExchangeValues
{
    static void Main()
    {
        int num1 = 5;
        int num2 = 10;
        int num3;
        Console.WriteLine("Before exchange, the first number is: {0}\tthe second number is: {1}", num1, num2);
        num3 = num1;
        num1 = num2;
        num2 = num3;
        Console.WriteLine("After exchange, the first number is: {0}\tthe second number is: {1}", num1, num2);
    }
}