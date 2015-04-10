/*
Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/

using System;
using System.Collections.Generic;

class PrintNumbersInRandomOrder
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

        List<int> newList = new List<int>();

        Random randomNumber = new Random();
        int element;

        do
        {
            element = randomNumber.Next(1, number + 1);
            if (newList.Contains(element))
            {
                continue;
            }
            else
            {
                newList.Add(element);
            }
        }
        while (newList.Contains(element) && newList.Count != number);

        Console.Write("Numbers from 1 to {0} in random order: ", number);
        for (int i = 0; i < newList.Count; i++)
        {
            Console.Write("{0}", newList[i]);

            if (i < newList.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

    }
}

