/*
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/


using System;

class CompareFloatingPointNumbers
{
    private static void AreTheyEqual(double eps, double result)
    {
        bool areEqual;

        if (result >= eps)
        {
            areEqual = false;
            Console.WriteLine("The two numbers are equal? - {0}", areEqual);
        }
        else
        {
            areEqual = true;
            Console.WriteLine("The two numbers are equal? - {0}", areEqual);
        }
    }

    private static double CalculateTheDifference(double numberOne, double numberTwo)
    {
        double difference;

        if (numberOne > numberTwo)
        {
            difference = numberOne - numberTwo;
        }
        else
        {
            difference = numberTwo - numberOne;
        }
        return difference;
    }
    static void Main()
    {
        double eps = 0.000001;

        Console.Write("Please enter your first number: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.Write("Please enter your second number: ");
        double numberTwo = double.Parse(Console.ReadLine());

        double result = CalculateTheDifference(numberOne, numberTwo);

        AreTheyEqual(eps, result);

    }
}

