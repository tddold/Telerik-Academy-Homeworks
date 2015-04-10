/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:

A)	                B)	                C)	                D)*
1	5	9	13      1	8	9	16      7	11	14	16      1	12	11	10
2	6	10	14      2	7	10	15      4	8	12	15      2	13	16	9
3	7	11	15      3	6	11	14      2	5	9	13      3	14	15	8
4	8	12	16      4	5	12	13      1	3	6	10      4	5	6	7

*/

using System;

class PrintMatrix
{
    static void PrintingMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void FillAndPrintMatrixVariantOne(int[,] matrix, int element)
    {
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row, col] = element++;
            }
        }

        PrintingMatrix(matrix);
    }

    static void FillAndPrintMatrixVariantTwo(int[,] matrix, int element)
    {
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, col] = element++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
                {
                    matrix[row, col] = element++;
                }
            }
        }

        PrintingMatrix(matrix);
    }

    static void FillAndPrintMatrixVariantThree(int[,] matrix, int element)
    {
        int row = 0;
        int col = 0;

        // Elements under the main diagonal
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            row = i;
            col = 0;

            while (row < matrix.GetLength(0) && col < matrix.GetLength(0))
            {
                matrix[row++, col++] = element++;
            }
        }

        // Elements over the main diagonal
        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            row = 0;
            col = i;

            while (row < matrix.GetLength(1) && col < matrix.GetLength(1))
            {
                matrix[row++, col++] = element++;
            }
        }

        PrintingMatrix(matrix);
    }

    static void FillAndPrintMatrixVariantFour(int[,] matrix, int element, int size)
    {
        int y = 0;
        int currentSize = size;

        int rowMaxLength = matrix.GetLength(0) - 1;
        int colMaxLength = matrix.GetLength(1) - 1;

        while (currentSize > 0)
        {
            for (int i = y; i <= rowMaxLength - y; i++)
            {
                matrix[i, y] = element++;
            }

            for (int i = y + 1; i <= colMaxLength - y; i++)
            {
                matrix[rowMaxLength - y, i] = element++;
            }

            for (int i = rowMaxLength - y - 1; i >= y; i--)
            {
                matrix[i, colMaxLength - y] = element++;
            }

            for (int i = colMaxLength - y - 1; i > y; i--) 
            {
                matrix[y, i] = element++;
            }

            y = y + 1;
            currentSize = currentSize - 2;
        }
        PrintingMatrix(matrix);
    }
    static void Main()
    {
        Console.Write("Please enter the size of your matrix: ");
        int size = Int32.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int element = 1;

        //Printing matrix variant A)

        Console.WriteLine("  Matrix #1");
        FillAndPrintMatrixVariantOne(matrix, element);
        Console.WriteLine();

        element = 1;

        //Printing matrix variant B)

        Console.WriteLine("  Matrix #2");
        FillAndPrintMatrixVariantTwo(matrix, element);
        Console.WriteLine();

        element = 1;

        //Printing matrix variant C)

        Console.WriteLine("  Matrix #3");
        FillAndPrintMatrixVariantThree(matrix, element);
        Console.WriteLine();

        element = 1;

        //Printing matrix variant D)

        Console.WriteLine("  Matrix #4");
        FillAndPrintMatrixVariantFour(matrix, element, size);
    }
}

