/*
Problem 6.* Matrix class

Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, 
indexer for accessing the matrix content and ToString().
*/

using System;

class CreatingMatrixClass
{
    static void Main()
    {
        Matrix firstMatrix = new Matrix(4, 4);
        Matrix secondMatrix = new Matrix(4, 4);

        Console.WriteLine("Please enter the element of your first matrix: ");

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                Console.Write("element[{0}.{1}] = ",row, col);
                firstMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Please enter the element of your second matrix: ");

        for (int row = 0; row < secondMatrix.Rows; row++)
        {
            for (int col = 0; col < secondMatrix.Cols; col++)
            {
                Console.Write("element[{0}.{1}]", row, col);
                secondMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Your first matrix is: ");
        Console.WriteLine(firstMatrix);

        Console.WriteLine("Your second matrix is: ");
        Console.WriteLine(secondMatrix);

        Console.WriteLine("Matrix 1 + Matrix 2");
        Console.WriteLine(firstMatrix + secondMatrix);

        Console.WriteLine("Matrix 1 - Matrix 2");
        Console.WriteLine(firstMatrix - secondMatrix);

        Console.WriteLine("Matrix 1 * Matrix 2");
        Console.WriteLine(firstMatrix * secondMatrix);
    }
}

