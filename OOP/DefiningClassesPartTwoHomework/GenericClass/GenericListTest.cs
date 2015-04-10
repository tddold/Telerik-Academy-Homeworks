namespace GenericClass
{
    using System;
    using System.Collections.Generic;

    public class GenericListTest
    {
        public static void Main()
        {
            // Testing with list of integers
            GenericList<int> listOfIntegers = new GenericList<int>();

            // Adding elements
            listOfIntegers.AddElement(8);
            listOfIntegers.AddElement(9);
            listOfIntegers.AddElement(5);
            listOfIntegers.AddElement(7);

            // Testing the indexator
            Console.Write("The list: ");
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                Console.Write(listOfIntegers[i]);

                if (i != listOfIntegers.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\n");
            
            // Inserting elements
            listOfIntegers.InsertElement(2, 10);
            listOfIntegers.InsertElement(4, 11);

            Console.WriteLine("After inserting elements: {0}", listOfIntegers.ToString());
            Console.WriteLine();

           // Removing elements
            listOfIntegers.RemoveElement(1);
            listOfIntegers.RemoveElement(3);

            Console.WriteLine("After removing elements: {0}", listOfIntegers.ToString());
            Console.WriteLine();

            Console.WriteLine("Max: {0}", listOfIntegers.Max<int>());
            Console.WriteLine("Min: {0}", listOfIntegers.Min<int>());

            // Finding element
            Console.WriteLine(listOfIntegers.FindElement(7));

            // Clear the list
            listOfIntegers.ClearGenericList();

            if (listOfIntegers.Count == 0)
            {
                Console.WriteLine("\nThe list is empty");
            }

            Console.WriteLine(new string('-', 50));

            // Testing with list of integers
            GenericList<string> listOfStrings = new GenericList<string>();

            // Adding elements
            listOfStrings.AddElement("Testing");
            listOfStrings.AddElement("some");
            listOfStrings.AddElement("variables");
            listOfStrings.AddElement("with strings");

            // Testing the indexator
            Console.Write("\nThe list: ");
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.Write(listOfStrings[i]);

                if (i != listOfStrings.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\n");

            // Inserting elements
            listOfStrings.InsertElement(2, "Hi from Penka");
            listOfStrings.InsertElement(4, "LOL");

            Console.WriteLine("After inserting elements: {0}", listOfStrings.ToString());
            Console.WriteLine();

            // Removing elements
            listOfStrings.RemoveElement(1);
            listOfStrings.RemoveElement(3);

            Console.WriteLine("After removing elements: {0}", listOfStrings.ToString());
            Console.WriteLine();

            // Compare strings by the ASCII table
            Console.WriteLine("Max: {0}", listOfStrings.Max<string>());
            Console.WriteLine("Min: {0}", listOfStrings.Min<string>());

            // Finding element
            Console.WriteLine(listOfStrings.FindElement("LOL"));

            // Clear the list
            listOfStrings.ClearGenericList();

            if (listOfStrings.Count == 0)
            {
                Console.WriteLine("\nThe list is empty");
            }
        }
    }
}
