/*
Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/
using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleOrString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Please choose you type.\n\nEnter 1 for int, 2 for double or 3 for string: ");
        int choose = Int32.Parse(Console.ReadLine());

        switch (choose)
        {
            case 1:
                {
                    Console.Write("Please enter a number from type int: ");
                    int number = int.Parse(Console.ReadLine());
                    int newNumber = number + 1;
                    Console.WriteLine("The result: {0}", newNumber);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a number from type double: ");
                    double number = Double.Parse(Console.ReadLine());
                    double newNumber = number + 1;
                    Console.WriteLine("The result: {0}", newNumber);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("The result: {0}*", text);
                    break;
                }
        }
    }
}

