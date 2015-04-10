/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
*/

using System;

class PrintLastDigitWithWords
{
    static void PrintDigitWithWords(int lastDigit)
    {
        switch (lastDigit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
        }
    }
    static void Main()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());

        PrintDigitWithWords(number % 10);
    }
}

