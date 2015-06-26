//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0
using System;
using System.Linq;
using System.Text;

namespace SolveTasks
{
    class SolveTasks
    {
        static void Header()
        {
            Console.Title = "Solve Tasks";
            Console.Clear();
            DateTime dtu = DateTime.Now;

            Console.WriteLine("\n\n\n\t\t\t\t\t" + dtu.ToString("dd.MM.yyyy"));
            Console.WriteLine("\t\t====================================");
            Console.WriteLine("\t\t\tSolve Tasks v0.1 beta");
            Console.WriteLine("\t\t====================================");
        }
        static void Footer()
        {
            Console.WriteLine("\t\t====================================");
        }
        static void ErrorMessage(String msg)
        {
            Header();
            Console.WriteLine("\n\n" + msg + "\n\n");
            Footer();
            Console.Write("\t\tPress a key to go back to main menu:");
            Console.ReadKey();
        }
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
        static decimal Average(int[] arr, int sequnce)
        {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            decimal average = sum / (decimal)sequnce;
            return average;
        }
        static decimal LinearEquation(decimal number1, decimal number2)
        {
            decimal result = (number2 * -1) / number1;

            return result;
        }
        static void Main()
        {
        beginning:
            Header();
        Console.WriteLine("\t\tPress 1 to Reverse the digits\r\n\t\tPress 2 to Calculate the average\r\n\t\tPress 3 to Solve a linear equation\r\n\t\tPress 4 to Exit");
            Footer();
            Console.Write("\t\tEnter your choice: ");
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                ErrorMessage("\t\tInsert only intergers!\r\n\t\t;(");
                goto beginning;
            }
            switch (choice)
            {
                case 1: Header();
                    Console.Write("\t\tEnter a number (number > 0): ");
                    try
                    {
                        decimal number = decimal.Parse(Console.ReadLine());
                        if (number < 0)
                        {
                            ErrorMessage("\t\tThe number should be > 0\r\n\t\t;(");
                            goto beginning;
                        }
                        Console.WriteLine("\t\tReversed number: {0}", ReversedNumber(number));
                        Footer();
                        Console.Write("\t\tPress a key to go back to main menu:");
                        Console.ReadKey();
                        goto beginning;
                    }
                    catch (Exception)
                    {
                        ErrorMessage("\t\tInsert only intergers!\r\n\t\t;(");
                        goto beginning;
                    }
                case 2: Header();
                    Console.Write("\t\tEnter lenght of sequence: ");
                    try
                    {
                        int sequence = int.Parse(Console.ReadLine());
                        if (sequence <= 0)
                        {
                            ErrorMessage("\t\tThe sequence should not be empty!\r\n\t\t;(");
                            goto beginning;
                        }
                        int[] arr = new int[sequence];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write("\t\tEnter number {0} in the sequence: ", i + 1);
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("\t\tAverage: {0}", Average(arr, sequence));
                        Footer();
                        Console.Write("\t\tPress a key to go back to main menu:");
                        Console.ReadKey();
                        goto beginning;
                    }
                    catch (Exception)
                    {
                        ErrorMessage("\t\tInsert only intergers!\r\n\t\t;(");
                        goto beginning;
                    }
                case 3: Header();
                    Console.WriteLine("\t\tLinear equation: a * x + b = 0");
                    try
                    {

                        Console.Write("\t\tEnter a (a!=0): ");
                        int a = int.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            ErrorMessage("\t\t\"a\" should not be zero!\r\n\t\t;(");
                            goto beginning;
                        }
                        Console.Write("\t\tEnter b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tx = (-b / a) = {0}", LinearEquation(a, b));
                        Footer();
                        Console.Write("\t\tPress a key to go back to main menu:");
                        Console.ReadKey();
                        goto beginning;
                    }
                    catch (Exception)
                    {
                        ErrorMessage("\t\tInsert only intergers!\r\n\t\t;(");
                        goto beginning;
                    }
                case 4: Console.WriteLine("\t\tBye, bye! :)");
                    System.Environment.Exit(0);
                    break;
                default: ErrorMessage("\t\tNot a valid input! Choose 1-4\r\n\t\t;(");
                    goto beginning;
            }
        }
    }
}