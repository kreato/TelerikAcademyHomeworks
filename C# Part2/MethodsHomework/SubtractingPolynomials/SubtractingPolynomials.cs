//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.
using System;
using System.Linq;

namespace SubtractingPolynomials
{
    class SubtractingPolynomials
    {
        static decimal[] SubstractOfPolinomials(decimal[] firsArray, decimal[] secondArray)
        {
            int longArray = firsArray.Length;
            int shortArray = secondArray.Length;
            if (secondArray.Length > firsArray.Length)
            {
                longArray = secondArray.Length;
                shortArray = firsArray.Length;
            }
            decimal[] result = new decimal[longArray];
            for (int i = 0; i < longArray; i++)
            {
                if (i > shortArray - 1)
                {
                    result[i] = firsArray.Length > secondArray.Length ? firsArray[i] : secondArray[i];
                }
                else
                {
                    result[i] = firsArray[i] - secondArray[i];
                }
            }
            return result;
        }
        static decimal[] MultiplyPolinomials(decimal[] firstArray, decimal[] secondArray)
        {
            decimal[] result = new decimal[firstArray.Length + secondArray.Length - 1];
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    result[i + j] += firstArray[i] * secondArray[j];
                }
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
            Console.Write("Substraction of Polinomials: ");
            PrintP(SubstractOfPolinomials(firstArray, secondArray));
            Console.Write("Multiplication of Polinomials: ");
            PrintP(MultiplyPolinomials(firstArray, secondArray));
        }
    }
}
