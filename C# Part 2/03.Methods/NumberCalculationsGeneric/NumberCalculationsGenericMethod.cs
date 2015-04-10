/*
Problem 15.* Number calculations

Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
*/

using System;
using System.Linq;

class NumberCalculationsGenericMethod
{
    static T Sum<T>(T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static T Average<T>(T[] array)
    {
        dynamic sum = 0;
        dynamic count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }

        return sum / (double)count;
    }

    static T Product<T>(T[] array)
    {
        dynamic product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        return product;
    }

    static T FindMax<T>(T[] array)
    {
        return array.Max();
    }

    static T FindMin<T>(T[] array)
    {
        return array.Min();
    }

    static void Main()
    {
        int[] numbers = { 7, 5, 1, 3, 9, 13 };

        //double[] numbers = { 8.78, -4.0011, 12, 5.998, 3.47, -12.4444, 79, 19, 2.71, 25, 6 };
        // decimal[] numbers = { -74.8745454, -1, -33.7888888, 9.412345, 6.119, 10 };
        // byte[] numbers = { 1, 2, 3, 9, 121, 21, 5, 7 };

        Console.WriteLine("Set of numbers: {0}", string.Join(", ", numbers));

        var sum = Sum(numbers);
        Console.WriteLine("Sum -> {0}", sum);

        var average = Average(numbers);
        Console.WriteLine("Average -> {0}", average);

        var product = Product(numbers);
        Console.WriteLine("Product -> {0}", product);

        var max = FindMax(numbers);
        Console.WriteLine("Max -> {0}", max);

        var min = FindMin(numbers);
        Console.WriteLine("Min -> {0}", min);
    }
}


