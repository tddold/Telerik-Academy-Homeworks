/*
Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. 
Use two nested loops.
Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
*/

using System;

class PrintMatrix
{
    static void Main()
    {
        int number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a positive integer number between 1 and 20: ");
            string value = Console.ReadLine();
            parseSuccessNumber = Int32.TryParse(value, out number);
        }
        while (parseSuccessNumber == false || number <= 1 || number > 20);

        for (int row = 1; row <= number; row++)
        {
            for (int col = row; col < number + row; col++)
            {
                 Console.Write("{0,2} ", col);
            }
            Console.WriteLine();
        }
    }
}

