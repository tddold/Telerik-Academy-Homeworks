/*
Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/

using System;

class AskForName
{
    static void AskForUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main()
    {
        AskForUserName();
    }
}

