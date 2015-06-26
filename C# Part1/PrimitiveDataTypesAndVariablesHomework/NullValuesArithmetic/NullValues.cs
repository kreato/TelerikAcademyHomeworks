//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.
using System;
class NullValues
{
    static void Main()
    {
        int? num1 = null;
        double? num2 = null;
        Console.WriteLine("{0},{1}",num1,num2);
        num1 = num1 + 5;
        num2 = num2 + 8.5;
        Console.WriteLine("{0},{1}",num1,num2);
        num1 = num1 + null;
        num2 = num2 + null;
        Console.WriteLine("{0},{1}",num1,num2);
    }
}