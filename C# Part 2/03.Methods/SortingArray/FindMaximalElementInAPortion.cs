/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class FindMaximalElementInAPortion
{
    public static List<int> portion = new List<int>();
    static void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static int FindMaxElementInPortion(int[] array, int position)
    {
        for (int i = position; i < array.Length; i++)
        {
            portion.Add(array[i]);
        }
        return portion.Max();
    }

    static void SortArrayAscending(int[] array, int max)
    {
        int index = portion.IndexOf(max);

        int a = array[index];
        array[index] = array[0];
        array[0] = a;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Please enter length of your array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        Console.WriteLine("Now fill the array with the elements:");
        FillArray(array);

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Your array: {0}", string.Join(", ", array));
        Console.WriteLine(new string('-', 50));

        Console.Write("Please enter a positive start up position: ");
        int index = int.Parse(Console.ReadLine());

        while (index < 0 || index > array.Length - 1)
        {
            Console.Write("Please enter a position which is bigger than 0 and smaller than {0}: ", array.Length - 1);
            index = int.Parse(Console.ReadLine());
        }

        int max = FindMaxElementInPortion(array, index);
        Console.WriteLine("The biggest number in the portion -> [{0}...{1}] is {2}", index, array.Length - 1, max);

        SortArrayAscending(array, max);
        Console.WriteLine("Your array sorted in ascending order: {0}", string.Join(", ", array));
    }
}

