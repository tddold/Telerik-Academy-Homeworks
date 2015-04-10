namespace Matrix
{
    using System;

    public class Matrix<T> where T : IComparable<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new InvalidOperationException("Invalid operation. The index must be a positive integer number");
            }
            else
            {
                this.matrix = new T[row, col];
            }
        }
        
        public int Row
        { 
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Col
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.matrix.GetLength(0) - 1) || (col < 0 || col > this.matrix.GetLength(1) - 1))
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                else
                {
                    return this.matrix[row, col];
                }
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        // Implement operator for addition
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row == secondMatrix.Row) && (firstMatrix.Col == secondMatrix.Col))
            {
                Matrix<T> thirdMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        thirdMatrix[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }

                return thirdMatrix;
            }
            else
            {
                throw new ArithmeticException("Invalid operation. The rows and columns of the two matrixes must be equal");
            }
        }

        // Implement operator for subtraction
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row == secondMatrix.Row) && (firstMatrix.Col == secondMatrix.Col))
            {
                Matrix<T> thirdMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        thirdMatrix[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                    }
                }

                return thirdMatrix;
            }
            else
            {
                throw new ArithmeticException("Invalid operation. The rows and columns of the two matrixes must be equal");
            }
        }

        // Implement operator for multiplication
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Row == secondMatrix.Row) && (firstMatrix.Col == secondMatrix.Col))
            {
                Matrix<T> thirdMatrix = new Matrix<T>(firstMatrix.Row, firstMatrix.Col);

                for (int row = 0; row < firstMatrix.Row; row++)
                {
                    for (int col = 0; col < firstMatrix.Col; col++)
                    {
                        dynamic currentElement = 0;

                        for (int i = 0; i < thirdMatrix.Col; i++)
                        {
                            currentElement += (dynamic)firstMatrix[row, i] * secondMatrix[i, col];
                        }

                        thirdMatrix[row, col] = currentElement;
                    }
                }

                return thirdMatrix;
            }
            else
            {
                throw new ArithmeticException("Invalid operation. The rows and columns of the two matrixes must be equal");
            }
        }

        // Implement operator true
        public static bool operator true(Matrix<T> firstMatrix)
        {
            bool isNonZero = true;

            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    if (firstMatrix[row, col].CompareTo(default(T)) == 0)
                    {
                        return false;
                    }
                }
            }

            return isNonZero;
        }

        // Implement operator false
        public static bool operator false(Matrix<T> firstMatrix)
        {
            bool isNonZero = false;

            for (int row = 0; row < firstMatrix.Row; row++)
            {
                for (int col = 0; col < firstMatrix.Col; col++)
                {
                    if (firstMatrix[row, col].CompareTo(default(T)) == 0)
                    {
                        return true;
                    }
                }
            }

            return isNonZero;
        }

        public void PrintMatrix()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", this.matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
