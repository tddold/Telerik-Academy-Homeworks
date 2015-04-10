/*
Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;
using System.Globalization;
using System.Threading;

class TheBiggestNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Enter your first number: ");
        double firstNumber = Double.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        double secondNumber = Double.Parse(Console.ReadLine());
        Console.Write("Enter your third number: ");
        double thirdNumber = Double.Parse(Console.ReadLine());

        double help = firstNumber;

        if ( firstNumber == secondNumber && thirdNumber == firstNumber)
        {
            Console.WriteLine("Sorry, I can't give you an answer. Your numbers are equal.");
        }
        else if (help < secondNumber && secondNumber > thirdNumber)
        {
            help = secondNumber;
            Console.WriteLine("The biggest number is {0}", help);
        }
        else if (help < thirdNumber && thirdNumber > secondNumber)
        {
            help = thirdNumber;
            Console.WriteLine("The biggest number is {0}", help);
        }
        else if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is {0}", help);
        }
        else if (firstNumber == secondNumber || firstNumber == thirdNumber || secondNumber == thirdNumber)
        {
            Console.WriteLine("Sorry, I can't give you an answer. You have two equal numbers.");
        }

        
    }
}

