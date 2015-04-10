/*
Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
*/

using System;

class Program
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
        while (parseSuccessNumber == false);

        int firstNumber = 0;
        int secondNumber = 1;
        int thirdNumber;

        Console.Write("The first {0} Fibonacci numbers: ", number);

        for (int i = 0; i < number; i++)
        {
            Console.Write("{0}", firstNumber);

            if (i != number - 1)
            {
                Console.Write(", ");
            }
            if (i == number - 1)
            {
                Console.WriteLine();
            }
            thirdNumber = secondNumber + firstNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
        }

    }
}

