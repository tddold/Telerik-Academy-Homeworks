/*
Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Numerics;

class CalculateFactorial
{
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
    }

    static BigInteger Factorial(int[] array)
    {
        BigInteger factorial = 1;
        for (int i = 0; i < array.Length; i++)
        {
            factorial *= array[i];
        }

        return factorial;
    }
    static void Main()
    {
        Console.Write("Please enter a number N: ");
        int number = int.Parse(Console.ReadLine());

        while (number <= 0 || number > 100)
        {
            Console.Write("The number must be between 1 and  100. Try again: ");
            number = int.Parse(Console.ReadLine());
        }

        int[] arrayNumber = new int[number];

        FillArray(arrayNumber);

        Console.WriteLine("{0}! = {1}", number, Factorial(arrayNumber));
    }
}

