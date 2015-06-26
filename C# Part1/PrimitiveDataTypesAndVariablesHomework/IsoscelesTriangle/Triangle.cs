//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
using System;
class Triangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        Console.WriteLine(@"
        {0}
       
       {0} {0}
      
      {0}   {0}

     {0} {0} {0} {0}", symbol);
    }
}