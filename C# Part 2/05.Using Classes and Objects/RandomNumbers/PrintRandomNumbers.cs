/*
Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

using System;

class PrintRandomNumbers
{
    static void Main()
    {
        Random numbers = new Random();

        Console.WriteLine("Ten random numbers in the range [100, 200]: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0}", numbers.Next(100, 200));

            if (i != 9)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();


    }
}

