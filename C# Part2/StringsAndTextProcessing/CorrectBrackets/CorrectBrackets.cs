//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
namespace CorrectBrackets
{
    using System;
    using System.Linq;
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Write an expression: ");
            string expression = Console.ReadLine();
            int counter = 0;
            foreach (var item in expression)
            {
                if (item == '(')
                {
                    counter++;
                }
                else if (item == ')')
                {
                    counter--;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
