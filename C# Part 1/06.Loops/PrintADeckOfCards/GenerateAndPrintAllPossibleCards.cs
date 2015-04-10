/*
Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
Note: You may use the suit symbols instead of text.
*/

using System;

class GenerateAndPrintAllPossibleCards
{
    static void Main()
    {
        char spades = '\u2660';
        char clubs = '\u2663';
        char hearts = '\u2665';
        char diamonds = '\u2666';

        char[] suits = { '\u2660', '\u2663', '\u2665', '\u2666' };
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int card = 0; card < cards.Length; card++)
        {
            for (int suit = 0; suit < suits.Length; suit++)
            {
                Console.Write("{0,2} of {1}", cards[card], suits[suit]);
                if (suit < suits.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

