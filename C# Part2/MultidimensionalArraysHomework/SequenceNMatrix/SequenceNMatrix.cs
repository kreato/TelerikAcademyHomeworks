//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;
class SequenceNMatrix
{
    static void Main()
    {
        //number of rows
        Console.Write("Enter the number of the rows: ");
        int n = int.Parse(Console.ReadLine());

        //number of cols
        Console.Write("Enter the number of the columns: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        //fill the matrix
        for (int row = 0; row < n; row++)
        {
            Console.Write("Enter {0} words devided by space: ", m);
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = (cells[col]);
            }
        }

        //print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        int sequenceVert = 1;
        int bestSequenceVert = 1;
        int sequenceHor = 1;
        int bestSequenceHor = 1;
        int sequenceDiag = 1;
        int bestSequenceDiag = 1;
        string elementHor = string.Empty;
        string elementVert = string.Empty;
        string elementDiag = string.Empty;

        //Hoziontals
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {

                if (matrix[rows, cols] == matrix[rows, cols + 1])
                {
                    sequenceHor++;
                }
                if (bestSequenceHor < sequenceHor)
                {
                    bestSequenceHor = sequenceHor;
                    elementHor = matrix[rows, cols];
                }
            }
            sequenceHor = 1;
        }

        //Verticals
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols])
                {
                    sequenceVert++;
                }
                if (bestSequenceVert < sequenceVert)
                {
                    bestSequenceVert = sequenceVert;
                    elementVert = matrix[rows, cols];
                }
            }
            sequenceVert = 1;
        }

        //Diagonals
        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                {
                    sequenceDiag++;
                }
                if (bestSequenceDiag < sequenceDiag)
                {
                    bestSequenceDiag = sequenceDiag;
                    elementDiag = matrix[rows, cols];
                }
            }
        }

        if (bestSequenceHor > bestSequenceVert && bestSequenceHor > bestSequenceDiag)
        {
            Console.WriteLine(bestSequenceHor);
            for (int i = 0; i < bestSequenceHor; i++)
            {
                Console.Write(elementHor);
                if (i == bestSequenceHor - 1)
                {
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        else if (bestSequenceVert > bestSequenceHor && bestSequenceVert > bestSequenceDiag)
        {
            Console.WriteLine(bestSequenceVert);
            for (int i = 0; i < bestSequenceVert; i++)
            {
                Console.Write(elementVert);
                if (i == bestSequenceVert - 1)
                {
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        else if (bestSequenceDiag > bestSequenceHor && bestSequenceDiag > bestSequenceVert)
        {
            Console.WriteLine(bestSequenceDiag);
            for (int i = 0; i < bestSequenceDiag; i++)
            {
                Console.Write(elementDiag);
                if (i == bestSequenceDiag - 1)
                {
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }

    }
}