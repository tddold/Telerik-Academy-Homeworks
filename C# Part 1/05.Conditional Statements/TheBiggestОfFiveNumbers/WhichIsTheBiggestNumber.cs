/*
Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/

using System;
using System.Globalization;
using System.Threading;

class WhichIsTheBiggestNumber
{
    static void Main()
    {
        while (true)
        {
            // First option
            
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Enter your first number: ");
            double firstNumber = Double.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            double secondNumber = Double.Parse(Console.ReadLine());

            Console.Write("Enter your third number: ");
            double thirdNumber = Double.Parse(Console.ReadLine());

            Console.Write("Enter your fourth number: ");
            double fourthNumber = Double.Parse(Console.ReadLine());

            Console.Write("Enter your fifth number: ");
            double fifthNumber = Double.Parse(Console.ReadLine());

            double biggestNumber = firstNumber;
            if (firstNumber < secondNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
            {
                biggestNumber = secondNumber;
                Console.WriteLine("The biggest number is {0}", biggestNumber);
                break;
            }
            if (firstNumber < thirdNumber && thirdNumber >= secondNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
            {
                biggestNumber = thirdNumber;
                Console.WriteLine("The biggest number is {0}", biggestNumber);
                break;
            }
            if (firstNumber < fourthNumber && fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
            {
                biggestNumber = fourthNumber;
                Console.WriteLine("The biggest number is {0}", biggestNumber);
                break;
            }
            if (firstNumber < fifthNumber && fifthNumber >= secondNumber && fifthNumber >= thirdNumber && fifthNumber >= fourthNumber)
            {
                biggestNumber = fifthNumber;
                Console.WriteLine("The biggest number is {0}", biggestNumber);
                break;
            }
            else 
            {
                Console.WriteLine("The biggest number is {0}", biggestNumber);
                break;
            }
        }

        // Second option

        /*
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double[] numbers = new double[5];

            Console.WriteLine("Please enter your five numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number [{0}] = ", i);
                double number = Double.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            double biggestNumber = numbers.Max();
            Console.WriteLine("The biggest number is: {0}", biggestNumber);
       */
    }
}

