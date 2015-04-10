/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;

class AssignsNullValues
{
    static void Main()
    {
        int? variableOne = null;
        double? variabletwo = null;

        Console.WriteLine("Nullable integer = {0}", variableOne);
        Console.WriteLine("Nullable double = {0}", variabletwo);

        variableOne = 24;
        variabletwo = 15.4511;

        Console.WriteLine("New value (integer): {0}", variableOne);
        Console.WriteLine("New value (double): {0}", variabletwo);
    }
}

