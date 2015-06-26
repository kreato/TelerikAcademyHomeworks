//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
namespace MaximalAreaSum
{
    using System;
    using System.IO;
    class MaximalAreaSum
    {
        static int[,] ReadMatrixFromFile()
        {
            using (StreamReader readMatrix = new StreamReader("../../Matrix.txt"))
            {
                int n = int.Parse(readMatrix.ReadLine());
                int[,] matrix = new int[n, n];
                string rowInfo = string.Empty;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    rowInfo = readMatrix.ReadLine();
                    string[] rowCells = rowInfo.Split(' ');
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = int.Parse(rowCells[j]);
                    }
                }
                return matrix;
            }
        }
        static int FindMaxSum(int[,] matrix)
        {

            int maxSum = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
        static void PrintResultToFile(int maxSum)
        {
            using (StreamWriter printResult = new StreamWriter("../../MaxSumResult.txt"))
            {
                printResult.WriteLine(maxSum);
            }
        }
        static void Main()
        {
            PrintResultToFile(FindMaxSum(ReadMatrixFromFile()));
            Console.WriteLine("Ready!");
        }
    }
}