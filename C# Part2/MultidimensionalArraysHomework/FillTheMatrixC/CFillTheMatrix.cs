//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n)
using System;
class CFillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        int rowBackCounter = 1;
        int colBackCounter = 0;
        int maxCount = n * n;

        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); )
            {
                matrix[row, col] = counter;

                if (counter == maxCount)
                {
                    break;
                }
                else if (row == matrix.GetLength(0) - 1 && col != matrix.GetLength(1) - 1)
                {
                    row -= rowBackCounter;
                    col -= colBackCounter;
                    rowBackCounter++;
                    colBackCounter++;
                }
                else if (row == matrix.GetLength(0) - 1 || col == matrix.GetLength(1) - 1)
                {
                    colBackCounter--;
                    rowBackCounter--;
                    col -= colBackCounter;
                    row -= rowBackCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                counter++;
            }
        }
        //print matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
