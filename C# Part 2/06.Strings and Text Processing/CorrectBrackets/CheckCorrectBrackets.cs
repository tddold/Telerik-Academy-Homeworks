namespace CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/
    class CheckCorrectBrackets
    {
        static bool CheckBrackets(string expression)
        {
            int bracketsCounter = 0;

            foreach (var item in expression)
            {
                if (item == '(')
                {
                    bracketsCounter++;
                }
                else if (item == ')')
                {
                    bracketsCounter--;
                }

                if (bracketsCounter < 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Please enter your expression: ");
            string expression = Console.ReadLine();

            if (CheckBrackets(expression))
            {
                Console.WriteLine("Correct expression");
            }
            else
            {
                Console.WriteLine("Incorrect expression");
            }
        }
    }
}
