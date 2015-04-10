/*
Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

using System;

class PrintIsDivisibleBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        string value = Console.ReadLine();
        int number;

        bool parseSuccess = Int32.TryParse(value, out number);

        if (parseSuccess == true)
        {
            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Your number can be divided by 7 and 5 at the same time.");
            }
            else
            {
                Console.WriteLine("Your number can't be divided by 7 and 5 at the same time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

    }
}

