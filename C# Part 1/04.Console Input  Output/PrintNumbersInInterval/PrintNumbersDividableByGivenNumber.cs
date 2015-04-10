/*
Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder 
of the division by 5 is 0.
*/

using System;

class PrintNumbersDividableByGivenNumber
{
    static void Main()
    {
        int firstNumber;
        bool parseSuccessFirstNumber = true;

        do
        {
            Console.Write("Please enter your first positive integer (start): ");
            string value = Console.ReadLine();
            parseSuccessFirstNumber = Int32.TryParse(value, out firstNumber);
        }
        while (parseSuccessFirstNumber == false || firstNumber <= 0);

        int secondNumber;
        bool parseSuccessSecondNumber = true;

        do
        {
            Console.Write("Please enter your second positive integer (end): ");
            string value = Console.ReadLine();
            parseSuccessSecondNumber = Int32.TryParse(value, out secondNumber);
        }
        while (parseSuccessSecondNumber == false || secondNumber < 0);

        int counter = 0;

        Console.Write("The numbers which are dividable by five and which are located between {0} and {1} are: ", firstNumber, secondNumber);
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("How many numbers dividable by five exist between {0} and {1}: {2}", firstNumber, secondNumber, counter);
    }
}

