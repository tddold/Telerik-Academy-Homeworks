/*
Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
*/

using System;
using System.Globalization;
using System.Threading;

class PrintMinMaxSumAverage
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please enter the lenght of your sequence: ");
        int number = Int32.Parse(Console.ReadLine());
        int[] sequence = new int[number];
        double sum = 0;
        double average = 0;

        for (int index = 0; index < number; index++)
        {
            Console.Write("Enter number {0}: ", index + 1);
            sequence[index] = Int32.Parse(Console.ReadLine());
        }

        int max = sequence[0];

        for (int index = 0; index < number; index++)
        {
            if (max < sequence[index])
            {
                max = sequence[index];
            }
        }

        Console.WriteLine("\nThe maximal number is {0}", max);

        int min = sequence[0];

        for (int index = 0; index < number; index++)
        {
            if (min > sequence[index])
            {
                min = sequence[index];
            }
        }

        Console.WriteLine("\nThe minimal numbers is {0}", min);

        for (int index = 0; index < number; index++)
        {
            sum += sequence[index];
        }

        Console.WriteLine("\nThe sum of all numbers is {0}", sum);

        average = sum / number;

        Console.WriteLine("\nThe average of all number is {0:F2}\n", average);
    }
}

