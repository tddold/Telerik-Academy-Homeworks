/*
Problem 13. Solve tasks

1. Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
2. Create appropriate methods.
3. Provide a simple text-based menu for the user to choose which task to solve.
4. Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
*/

using System;

class DifferentTasks
{
    static void SolvingDifferentTasks(int choise)
    {
        if (choise == 1)
        {
            Console.Write("Please enter a positive number you want to reverse: ");
            string number = Console.ReadLine();

            while (int.Parse(number) < 1)
            {
                Console.Write("Please enter a positive number. Try again: ");
                number = Console.ReadLine();
            }

            string reverseNumber = ReverseNumber(number);
            Console.WriteLine("Your reversed decimal number: {0}", reverseNumber);
        }
        else if (choise == 2)
        {
            Console.Write("Please enter your sequence of integers: ");
            string sequence = Console.ReadLine();

            string[] array = sequence.Split(new char[] { ' ', '\t', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (array.Length == 0)
            {
                while (array.Length == 0)
                {
                    Console.Write("The sequence should not be empty. Please try again: "); 
                    sequence = Console.ReadLine();
                    array = sequence.Split(new char[] { ' ', '\t', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            int[] numbers = new int[array.Length];

            int sum = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
                sum += numbers[i];
                count++;
            }

            Console.WriteLine("The average of your sequence is: {0}", CalculateAverage(sum, count));
        }
        else
        {
            Console.Write("Please enter your coefficient A: ");
            int a = int.Parse(Console.ReadLine());

            while (a == 0)
            {
                Console.Write("Your coefficient A must be different from zero. Try again: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Please enter your coefficient B: ");
            int b = int.Parse(Console.ReadLine());

            SolveLinearEquation(a, b);
        }
    }

    static string ReverseNumber(string number)
    {
        string reverseNumber = string.Empty;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            reverseNumber += number[i].ToString();
        }

        return reverseNumber;
    }

    static int CalculateAverage(int sum, int count)
    {
        return sum / count;
    }

    static void SolveLinearEquation(int a, int b)
    {
        string result = string.Empty;

        if ((b < 0 && a < 0) || (b > 0 && a > 0))
        {
            Console.WriteLine("The answer of linear equation is: x = -{0}/{1}", Math.Abs(b), Math.Abs(a));
        }
        else if ((b > 0 && a < 0) || (b < 0 && a > 0))
        {
            Console.WriteLine("The answer of linear equation is: x = {0}/{1}", Math.Abs(b), Math.Abs(a));
        }
        else if (b == 0)
        {
            Console.WriteLine("The answer of linear equation is: x = 0");
        }
    }
    static void Main()
    {
        Console.Write(@"Enter 1: To reverse the digits of a number.
Enter 2: To calculate the average of a sequence of integers.
Enter 3: To solve a linear equation -> A*x + B = 0
Please enter you choise: ");

        int choise = int.Parse(Console.ReadLine());

        while (choise < 1 || choise > 3)
        {
            Console.Write("Please choose between 1, 2 and 3. Try again: ");
            choise = int.Parse(Console.ReadLine());
        }

        SolvingDifferentTasks(choise);
    }
}

