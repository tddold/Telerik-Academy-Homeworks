/*Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalAreaSum
{
    class FindMaxSum
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"..\..\..\matrix.txt", Encoding.ASCII);

            using (firstFile)
            {
                string line = firstFile.ReadLine();
                int size = Int32.Parse(line);
                int[,] matrix = new int[size, size];
                int rows = 0;
                int bestStum = 0;
                while (line != null)
                {
                    line = firstFile.ReadLine();
                    if (line != null)
                    {
                        string[] str = line.Split(' ');

                        for (int i = rows; i <= rows; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                matrix[i, j] = Int32.Parse(str[j]);
                            }
                        }
                        rows++;
                    }
                }


                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                        if (sum > bestStum)
                        {
                            bestStum = sum;
                        }
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("The max sum of 2x2 is {0}", bestStum);
            }

        }
    }
}
