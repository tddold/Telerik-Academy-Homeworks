/*
Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, 
separated by a space.
*/

using System;

class PrintNumbersFromOneToN
{
    public static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positve integer: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number <= 0);

        Console.Write("All numbers from 1 to {0}: ", number);

        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            Console.Write(currentNumber + " ");
        }

        Console.WriteLine();
    }
}