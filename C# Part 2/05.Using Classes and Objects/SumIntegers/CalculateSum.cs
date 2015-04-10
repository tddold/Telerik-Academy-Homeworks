/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	                    output
"43 68 9 23 318"	        461

*/

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Please enter your numbers separated by space: ");
        string numbers = Console.ReadLine();

        string[] array = numbers.Split(' ');

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += int.Parse(array[i].ToString());
        }

        Console.WriteLine("The sum of your numbers is {0}", sum);

    }
}

