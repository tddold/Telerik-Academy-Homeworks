/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FillArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
    }

    static void SortingStringArrayByLength(string[] array)
    {
        var sortedElements = array.OrderBy(x => x.Length);

        Console.WriteLine(string.Join(", ", sortedElements));
    }
    static void Main()
    {
        Console.Write("Please enter the length of your string array: ");
        int length = int.Parse(Console.ReadLine());

        string[] stringArray = new string[length];

        Console.WriteLine("Please enter the elements of your string:");
        FillArray(stringArray);

        Console.WriteLine("Your array before the sort:");
        Console.WriteLine(string.Join(", ", stringArray));

        Console.WriteLine(new string('-', 50));

        Console.WriteLine("Your array after the sort (sorted by length):");
        SortingStringArrayByLength(stringArray);


    }
}

