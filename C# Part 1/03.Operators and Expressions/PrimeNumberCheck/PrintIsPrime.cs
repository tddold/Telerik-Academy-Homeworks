/*
Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n = 100) 
is prime (i.e. it is divisible without remainder only to itself and 1).
*/

using System;

class PrintIsPrime
{
    static void Main()
    {
        int number;
        bool parseSuccess = true;

        do
        {
            Console.Write("Please enter a number between 0 and 100: ");
            string value = Console.ReadLine();
            parseSuccess = Int32.TryParse(value, out number);
        }
        while (parseSuccess == false || number > 100 || number < 0);

        bool isPrime = true;

        if (number == 1 || number == 0)
        {
            isPrime = false;
        }

        for (int i = 2; i < number; i++)
        {
            if ((number % i) == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime == true)
        {
            Console.WriteLine("Your number is prime.");
        }
        else
        {
            Console.WriteLine("Your number is not prime.");
        }
    }
}

