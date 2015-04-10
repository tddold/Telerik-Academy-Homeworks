/*
Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertToDifferentSystems
{
    static string ConvertFromDecimal(int number, int systemBase)
    {
        StringBuilder result = new StringBuilder();

        if (number == 0)
        {
            result.Insert(0, "0");
            return result.ToString();
        }

        while (number > 0)
        {
            long reminder = number % systemBase;
            number = number / systemBase;

            switch (reminder)
            {
                case 1: result.Insert(0, "1"); break;
                case 2: result.Insert(0, "2"); break;
                case 3: result.Insert(0, "3"); break;
                case 4: result.Insert(0, "4"); break;
                case 5: result.Insert(0, "5"); break;
                case 6: result.Insert(0, "6"); break;
                case 7: result.Insert(0, "7"); break;
                case 8: result.Insert(0, "8"); break;
                case 9: result.Insert(0, "9"); break;
                case 10: result.Insert(0, "A"); break;
                case 11: result.Insert(0, "B"); break;
                case 12: result.Insert(0, "C"); break;
                case 13: result.Insert(0, "D"); break;
                case 14: result.Insert(0, "E"); break;
                case 15: result.Insert(0, "F"); break;
                default: result.Insert(0, "0"); break;
            }
        }

        return result.ToString();
    }

    static int ConvertToDecimal(string number, int systemBase)
    {
        int numberInDecimal = 0;
        for (int index = 0; index < number.Length; index++)
        {
            if (char.IsDigit(number[index]))
            {
                numberInDecimal += (int)Math.Pow(systemBase, number.Length - index - 1) * (number[index] - '0');
            }
            else //if (number[index] >= 65 && number[index] <= 70)
            {
                numberInDecimal += (int)Math.Pow(systemBase, number.Length - index - 1) * (number[index] - 55);
            }
        }

        return numberInDecimal;
    }

    static void Main()
    {
        Console.WriteLine("Please enter your choise:");
        Console.Write("Convert from -> ");
        int firstBase = int.Parse(Console.ReadLine());

        if (firstBase < 2)
        {
            Console.Write("Your first base must be bigger or equal to 2. Please try again: ");
            firstBase = int.Parse(Console.ReadLine());
        }

        Console.Write("Convert to -> ");
        int secondBase = int.Parse(Console.ReadLine());

        if (secondBase > 16)
        {
            Console.Write("Your second base must be bigger or equal to 16. Please try again: ");
            firstBase = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter your number (represented in base {0}) which you want to convert to base {1}.\nEnter: ", firstBase, secondBase);
        string number = Console.ReadLine().ToUpper();
        Console.WriteLine("Result {0}", ConvertFromDecimal(ConvertToDecimal(number, firstBase), secondBase));
    }
}