/*
Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
*/


using System;
using System.Globalization;
using System.Threading;

class CheckForMultiplicationSign
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

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product is 0.");
        }
        else if ((firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0))
        {
            Console.WriteLine("The product is negative (Minus -).");
        }
        else if ((firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) || (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0))
        {
            Console.WriteLine("The product is positive (Plus +).");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The product is negative (Minus -).");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The product is positive (Plus +)");
        }
    }
}

