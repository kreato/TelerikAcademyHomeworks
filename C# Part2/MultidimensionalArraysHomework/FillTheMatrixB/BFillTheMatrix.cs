//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n)
using System;
class BFillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                } 
            }
            else
            {
                for (int row = n-1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
