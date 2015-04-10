/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */
using System;

class CaculateMaximalSum
{
    static int[,] FillMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0}.{1}] = ", row, col);
                matrix[row, col] = Int32.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static int CalculateMaximalSumPlatform(int[,] matrix)
    {
        int bestRow = 0;
        int bestCol = 0;
        int sum = 0;
        int bestSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = SumElements(matrix, row, col);

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        PrintPlatform(matrix, bestRow, bestCol);
        return bestSum;
    }

    static int SumElements(int[,] matrix, int row, int col)
    {
        int sum = matrix[row, col] 
            + matrix[row, col + 1] 
            + matrix[row, col + 2] 
            + matrix[row + 1, col] 
            + matrix[row + 1, col + 1] 
            + matrix[row + 1, col + 2] 
            + matrix[row + 2, col] 
            + matrix[row + 2, col + 1] 
            + matrix[row + 2, col + 2];

        return sum;
    }

    static void PrintPlatform(int[,] matrix, int bestRow, int bestCol)
    {
        Console.WriteLine("The platform 3x3 with the biggest sum of its elements:\n");
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Please enter the number of rows in your matrix: ");
        int rows = Int32.Parse(Console.ReadLine());

        Console.Write("Please enter the numbers of columns in your matrix: ");
        int cols = Int32.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 50));

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Please");
        FillMatrix(matrix);

        int bestSum = CalculateMaximalSumPlatform(matrix);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The maximal sum is {0}", bestSum);
    }
}

