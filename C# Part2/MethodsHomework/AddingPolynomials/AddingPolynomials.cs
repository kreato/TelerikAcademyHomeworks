//Problem 11. Adding polynomials
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
using System;
using System.Linq;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static decimal[] SumOfPolinomials(decimal[] firstArray, decimal[] secondArray)
        {
            int longArray = firstArray.Length;
            int shortArray = secondArray.Length;
            if (firstArray.Length < secondArray.Length)
            {
                longArray = secondArray.Length;
                shortArray = firstArray.Length;
            }
            decimal[] result = new decimal[longArray];
            for (int i = 0; i < shortArray; i++)
            {
                result[i] = (firstArray[i] + secondArray[i]);
            }
            for (int i = shortArray; i < longArray; i++)
            {
                result[i] = (firstArray.Length > secondArray.Length ? firstArray[i] : secondArray[i]);
            }
            return result;
        }
        static void PrintP(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Enter lenght of the first array: ");
            int n = int.Parse(Console.ReadLine());
            decimal[] firstArray = new decimal[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter index [{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter lenght of the second array: ");
            int m = int.Parse(Console.ReadLine());
            decimal[] secondArray = new decimal[m];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Enter index [{0}]: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Sum of Polinomials: ");
            PrintP(SumOfPolinomials(firstArray, secondArray));
        }
    }
}