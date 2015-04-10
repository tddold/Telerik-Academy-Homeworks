namespace Matrix
{
    using System;

    public class MatrixTest
    {
        public static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(4, 4);

            Matrix<int> secondMatrix = new Matrix<int>(4, 4);

            for (int i = 0; i < firstMatrix.Row; i++)
            {
                for (int j = 0; j < firstMatrix.Col; j++)
                {
                    firstMatrix[i, j] = j + 3;
                }
            }

            for (int i = 0; i < secondMatrix.Row; i++)
            {
                for (int j = 0; j < secondMatrix.Col; j++)
                {
                    secondMatrix[i, j] = j * 2;
                }
            }

           // Console.WriteLine("Matrix one:");
           // firstMatrix.PrintMatrix();
              
           // Console.WriteLine("\nMatrix two:");
           // secondMatrix.PrintMatrix();

            Matrix<int> thirdMatrix = firstMatrix + secondMatrix;

            Console.WriteLine("\nAdding:");
            thirdMatrix.PrintMatrix();

            thirdMatrix = firstMatrix - secondMatrix;

            Console.WriteLine("\nSubtraction:");
            thirdMatrix.PrintMatrix();

            thirdMatrix = firstMatrix * secondMatrix;

            Console.WriteLine("\nMultiplication:");
            thirdMatrix.PrintMatrix();

            Console.Write("\nCheck for zero element in the Matrix one: ");
            if (firstMatrix)
            {
                Console.WriteLine("There isn't zero element");
            }
            else
            {
                Console.WriteLine("There is zero element");
            }

            Console.Write("Check for zero element in the Matrix two: ");
            if (secondMatrix)
            {
                Console.WriteLine("There isn't zero element");
            }
            else
            {
                Console.WriteLine("There is zero element");
            }
        }
    }
}
