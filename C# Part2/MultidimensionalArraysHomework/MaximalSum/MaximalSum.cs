//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
class MaximalSum
{
    static void Main()
    {
        //number of rows
        Console.Write("Enter the number of the rows: ");
        int n = int.Parse(Console.ReadLine());

        //number of cols
        Console.Write("Enter the number of the columns: ");
        int m = int.Parse(Console.ReadLine());
        if (n > m)
        {
            Console.WriteLine("number of the rows should be > number of the columns");
            return;
        }

        int[,] matrix = new int[n, m];

        //fill the matrix
        for (int row = 0; row < n; row++)
        {
            Console.Write("Enter {0} numbers devided by space: ", m);
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < m; col++)
            {

                matrix[row, col] = int.Parse(cells[col]);
            }
        }

        //print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //find the maximal sum platform of size 3 x 3

        if (matrix.GetLength(0) < 4 || matrix.GetLength(1) < 4)
        {
            Console.WriteLine("Not a valid matrix");
            return;
        }

        int bestRow = 0;
        int bestCol = 0;

        int bestSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 3] +
                      matrix[1, 0] + matrix[1, 1] + matrix[1, 3] +
                      matrix[2, 0] + matrix[2, 1] + matrix[2, 3];

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int newSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                             matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                             matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (bestSum < newSum)
                {
                    bestSum = newSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The maximal sum platform of size 3 x 3 is: {0}", bestSum);
        Console.WriteLine("Best matrix: ");
        Console.WriteLine("{0}, {1}, {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0}, {1}, {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0}, {1}, {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
    }
}
