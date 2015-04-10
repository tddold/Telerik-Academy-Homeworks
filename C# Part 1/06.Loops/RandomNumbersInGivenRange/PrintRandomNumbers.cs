/*
Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
*/

using System;

class PrintRandomNumbers
{
    static void Main()
    {
        int n;
        bool parseSuccessN = true;

        do
        {
            Console.Write("Please enter the lenght of your sequence: ");
            string value = Console.ReadLine();
            parseSuccessN = Int32.TryParse(value, out n);
        }
        while (parseSuccessN == false);

        int min;
        bool parseSuccessMin = true;

        do
        {
            Console.Write("Enter the min of your sequence: ");
            string value = Console.ReadLine();
            parseSuccessMin = Int32.TryParse(value, out min);
        }
        while (parseSuccessMin == false);

        int max;
        bool parseSuccessMax = true;

        do
        {
            Console.Write("Enter the max of your sequence. It must be bigger that {0}: ", min);
            string value = Console.ReadLine();
            parseSuccessMin = Int32.TryParse(value, out max);
        }
        while (parseSuccessMax == false || max == min || max < min);

        Random randomNumbers = new Random();

        Console.Write("{0} random numbers in the range [{1} - {2}]: ", n, min, max);

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0, 2} ", randomNumbers.Next(min, max));
        }
        Console.WriteLine();
    }
}

