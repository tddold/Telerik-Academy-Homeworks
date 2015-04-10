/*
Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.
*/

using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive number: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number <= 0);

        Console.WriteLine();
        Console.WriteLine("All numbers from 1 to {0}:", number);
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

