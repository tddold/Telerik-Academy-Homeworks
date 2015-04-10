/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/

using System;

class IntCalculations
{
    static int Sum(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int Average(int[] array)
    {
        int sum = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }

        return sum / count;
    }

    static long Product(int[] array)
    {
        long product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static int FindMax(int[] array)
    {
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int FindMin(int[] array)
    {
        int min = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static void Main()
    {
        int[] numbers = { 7, 5, 1, 3, 9, 13 };

        // int[] numbers = { 8, 4, 12, 5, 3, 12, 79, 19, 21, 25, 6 };
        // int[] numbers = { -74, -1, -33, 9, 69, 10 };
        // int[] numbers = { 1, 2, 3, 9, 121, 21, 5, 7 };

        Console.WriteLine("Set of numbers: {0}", string.Join(", ", numbers));

        int sum = Sum(numbers);
        Console.WriteLine("Sum -> {0}", sum);

        int average = Average(numbers);
        Console.WriteLine("Average -> {0}", average);

        long product = Product(numbers);
        Console.WriteLine("Product -> {0}", product);

        int max = FindMax(numbers);
        Console.WriteLine("Max -> {0}", max);

        int min = FindMin(numbers);
        Console.WriteLine("Min -> {0}", min);
    }
}

