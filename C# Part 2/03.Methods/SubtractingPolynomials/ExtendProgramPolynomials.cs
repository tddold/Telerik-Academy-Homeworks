/*
Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.
*/

using System;

class ExtendProgramPolynomials
{
    static void EnterCoefficints(int[] array, int degree)
    {
        for (int i = degree; i >= 0; i--)
        {
            Console.Write("x^{0} -> ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void PrintPolynomials(int[] array)
    {
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {

            if (array.Length - 1 - i == 0)
            {
                Console.WriteLine(" {0}", array[0]);

                if (i != array.Length - 1)
                {
                    Console.Write(" +");
                }
            }
            else
            {
                Console.Write(" {0}x^{1}", array[j], array.Length - 1 - i);

                if (i != array.Length - 1)
                {
                    Console.Write(" +");
                }
            }

        }
    }

    static int[] SubtractingPolynomials(int[] arrayOne, int[] arrayTwo)
    {
        int[] arrayThree = new int[arrayOne.Length];

        for (int i = 0; i < arrayThree.Length; i++)
        {
            arrayThree[i] = arrayOne[i] - arrayTwo[i];
        }

        return arrayThree;
    }

    static int[] MultiplicationPolynomials(int[] arrayOne, int[] arrayTwo)
    {
        int[] arrayThree = new int[arrayOne.Length];

        for (int i = 0; i < arrayThree.Length; i++)
        {
            arrayThree[i] = arrayOne[i] * arrayTwo[i];
        }

        return arrayThree;
    }

    static void PrintPolynomialsMultiplication(int[] array)
    {
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {

            if (array.Length - 1 - i == 0)
            {
                Console.WriteLine(" {0}", array[0]);

                if (i != array.Length - 1)
                {
                    Console.Write(" +");
                }
            }
            else
            {
                Console.Write(" {0}x^{1}", array[j], (array.Length - 1 - i) * (array.Length - 1 - i));

                if (i != array.Length - 1)
                {
                    Console.Write(" +");
                }
            }

        }
    }
    static void Main()
    {
        Console.Write("Please first enter your polynomial degree: ");
        int degree = int.Parse(Console.ReadLine());

        int[] firstPolynomial = new int[degree + 1];
        int[] secondPolynomial = new int[degree + 1];

        Console.WriteLine("Please now enter your coefficients of the first polynomial: ");
        EnterCoefficints(firstPolynomial, degree);

        Console.WriteLine("Please now enter your coefficients of the second polynomial: ");
        EnterCoefficints(secondPolynomial, degree);

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Your polynomials are:\n");
        PrintPolynomials(firstPolynomial);
        PrintPolynomials(secondPolynomial);

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Subtracting two polynomials:\n");
        PrintPolynomials(firstPolynomial);
        Console.WriteLine("-");
        PrintPolynomials(secondPolynomial);
        Console.WriteLine("=");
        PrintPolynomials(SubtractingPolynomials(firstPolynomial, secondPolynomial));

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Multiplicating two polynomials:\n");
        PrintPolynomials(firstPolynomial);
        Console.WriteLine("*");
        PrintPolynomials(secondPolynomial);
        Console.WriteLine("=");
        PrintPolynomialsMultiplication(MultiplicationPolynomials(firstPolynomial, secondPolynomial));

        Console.WriteLine(new string('-', 50));
    }
}

