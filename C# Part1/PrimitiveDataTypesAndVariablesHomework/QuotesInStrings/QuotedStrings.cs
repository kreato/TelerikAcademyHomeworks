//Problem 7. Quotes in Strings
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.
using System;
class QuotedStrings
{
    static void Main()
    {
        string quotation1 = @"The ""use"" of quotations causes difficulties.";
        string quotation2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("First way: {0}\nSecond way: {1}", quotation1, quotation2);
    }
}