using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix
{
    private int[,] matrix;

    public Matrix(int row, int col)
    {
        this.matrix = new int[row, col];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix thirdMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                thirdMatrix[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }
        return thirdMatrix;
    }

    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix thirdMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                thirdMatrix[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }
        return thirdMatrix;
    }

    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        Matrix thirdMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                int currentElement = 0;
                for (int index = 0; index < thirdMatrix.Cols; index++)
                {
                    currentElement += firstMatrix[row, index] * secondMatrix[index, col];
                }
                thirdMatrix[row, col] = currentElement;
            }
        }
        return thirdMatrix;
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = string.Empty;

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                result += matrix[row, col] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}

