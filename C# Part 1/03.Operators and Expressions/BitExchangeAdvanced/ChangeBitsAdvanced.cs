/*
Problem 16.** Bit Exchange (Advanced)

Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.
*/

using System;

class ChangeBitsAdvanced
{
    private static uint ParsingNumber()
    {
        uint number;
        bool parseSuccessNumber = true;

        do
        {
            Console.Write("Please enter a 32-bit unsigned integer: ");
            string value = Console.ReadLine();
            parseSuccessNumber = UInt32.TryParse(value, out number);
            Console.WriteLine(parseSuccessNumber ? "" : "Not a number or out of range. Try again: ");
        }
        while (parseSuccessNumber == false || number < 0);
        return number;
    }

    private static int ParsingFirstPosition()
    {
        int firstPosition;
        bool parseSuccessFirstPosition = true;

        do
        {
            Console.Write("Please enter your first position: ");
            string value = Console.ReadLine();
            parseSuccessFirstPosition = Int32.TryParse(value, out firstPosition);
        }
        while (parseSuccessFirstPosition == false);
        return firstPosition;
    }

    private static int ParsingSecondPosition()
    {
        int secondPosition;
        bool parseSuccessSecondPosition = true;

        do
        {
            Console.Write("Please enter your second position: ");
            string value = Console.ReadLine();
            parseSuccessSecondPosition = Int32.TryParse(value, out secondPosition);
        }

        while (parseSuccessSecondPosition == false);
        return secondPosition;
    }

    private static int ParsingCounter()
    {
        int counter;
        bool parseSuccessCounter = true;

        do
        {
            Console.Write("Please enter a counter: ");
            string value = Console.ReadLine();
            parseSuccessCounter = Int32.TryParse(value, out counter);
        }
        while (parseSuccessCounter == false);
        return counter;
    }

    private static uint ExchangeBits(uint number, int firstPosition, int secondPosition, int counter)
    {
        for (int i = firstPosition, j = secondPosition; (i <= 32 && j <= 32) && i < firstPosition + counter; i++, j++)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = number ^ (uint)(1 << i);
                number = number ^ (uint)(1 << j);
            }
        }
        return number;
    }

    static void Main()
    {
        uint number = ParsingNumber();

        int firstPosition = ParsingFirstPosition();

        int secondPosition = ParsingSecondPosition();

        Console.WriteLine("\nNow you need to enter a counter.\nExample: \nFirst position = 7\nSecond position =  21\nCounter = 3\nThe sequence of bits are -> 7, 8, 9 and 21, 22, 23\n");

        int counter = ParsingCounter();

        if ((firstPosition + counter > 32) || (secondPosition + counter > 32) || (firstPosition < 0) || (secondPosition < 0))
        {
            Console.WriteLine("Error: out of range!");
            return;
        }
        else
        {
            for (int i = firstPosition, c = counter; i < firstPosition + counter; i++)
            {
                for (int j = secondPosition; j < secondPosition + counter; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine("Error: overlapping!");
                        return;
                    }
                }
            }
        }

        number = ExchangeBits(number, firstPosition, secondPosition, counter);
        Console.WriteLine("Your integer after the exchange: {0}", number);

    }
}


