/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	            result		     matrix	      result
ha	fifi ho	hi                       s	qq	s
fo	ha	hi	xx      ha, ha, ha       pp	pp	s     s, s, s
xxx	ho	ha	xx                       pp	qq	s
*/

using System;
using System.Collections.Generic;
using System.Linq;

class FindSequenceInMatrix
{
    public static List<int> bestLength = new List<int>();
    public static List<string> bestElement = new List<string>();

    static string[,] FillMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("element[{0}.{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        Console.WriteLine();
        return matrix;
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void CheckForSequenceInMatrix(string[,] matrix)
    {
        CheckRows(matrix);
        CheckCols(matrix);
        CheckUnderTheMainDiagonal(matrix);
        CheckOverTheMainDiagonal(matrix);
        CheckOverTheSecondDiagonal(matrix);
        CheckUnderTheSecondDiagonal(matrix);

        int biggestNumber = bestLength.Max();
        int index = bestLength.IndexOf(biggestNumber);

        PrintMatrixSequence(biggestNumber, index);

    }

    static void CheckCols(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            currentElement = matrix[0, col];

            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (currentElement == matrix[row + 1, col])
                {
                    counter++;
                    row++;

                    if (counter > maxCounter && counter == matrix.GetLength(0))
                    {
                        maxCounter = counter;
                        element = currentElement;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                    break;
                }
            }
            row = 0;
            col++;
        }

        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckRows(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            currentElement = matrix[row, 0];

            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (currentElement == matrix[row, col + 1])
                {
                    counter++;
                    col++;

                    if (counter > maxCounter && counter == matrix.GetLength(1))
                    {
                        maxCounter = counter;
                        element = currentElement;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                    break;
                }
            }
            col = 0;
            row++;
        }
        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckUnderTheMainDiagonal(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            row = i;
            currentElement = matrix[row, 0];

            while (row < matrix.GetLength(0) - 1)
            {
                if (currentElement == matrix[++row, ++col])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        element = currentElement;
                    }
                }
                else
                {
                    break;
                }
            }
            col = 0;
            counter = 1;


        }

        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckOverTheMainDiagonal(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            col = i;
            currentElement = matrix[0, col];

            while (col < matrix.GetLength(1) - 1)
            {
                if (currentElement == matrix[++row, ++col])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                element = currentElement;
            }
            row = 0;
            counter = 1;
        }

        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckOverTheSecondDiagonal(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            row = i;
            currentElement = matrix[row, col];

            while (row > 0 && col < matrix.GetLength(1) - 1)
            {
                if (currentElement == matrix[--row, ++col])
                {
                    counter++;

                }
                else
                {
                    break;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = currentElement;
                }
                else
                {
                    continue;
                }
            }
            col = 0;
            counter = 1;
        }

        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckUnderTheSecondDiagonal(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = "?";
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            col = i;
            row = matrix.GetLength(0) - 1;
            currentElement = matrix[row, col];

            while (col < matrix.GetLength(0) - 1)
            {
                if (currentElement == matrix[--row, ++col])
                {
                    counter++;

                }
                else
                {
                    break;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = currentElement;
                }
                else
                {
                    continue;
                }
            }
            counter = 1;

        }
        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }
    
    static void PrintMatrixSequence(int biggestNumber, int index)
    {
        for (int i = 0; i < biggestNumber; i++)
        {
            Console.Write(bestElement[index]);

            if (i != biggestNumber - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Please enter the number of rows in your matrix: ");
        int rows = Int32.Parse(Console.ReadLine());

        Console.Write("Please enter the numbers of columns in your matrix: ");
        int cols = Int32.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        Console.WriteLine("Please enter the elements of your matrix:");
        FillMatrix(matrix);

        Console.WriteLine("Your matrix:");
        PrintMatrix(matrix);

        Console.WriteLine("The longest sequence is: ");
        CheckForSequenceInMatrix(matrix);
    }
}

