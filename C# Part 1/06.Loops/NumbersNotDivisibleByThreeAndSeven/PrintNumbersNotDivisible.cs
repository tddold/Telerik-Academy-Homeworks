/*
Problem 2. Numbers Not Divisible by 3 and 7

Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, 
on a single line, separated by a space.*/

using System;

class PrintNumbersNotDivisible
{
    static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive integer: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number <= 0);

        Console.WriteLine("All numbers from 1 to {0} which are not divisible by 3 and 7:", number);
        for (int currentNumber = 1; currentNumber <= number; currentNumber++)
        {
            if ((currentNumber % 3 != 0) && (currentNumber % 7 != 0))
            {
                Console.Write(currentNumber + " ");
            }
        }
        Console.WriteLine();
    }
}
