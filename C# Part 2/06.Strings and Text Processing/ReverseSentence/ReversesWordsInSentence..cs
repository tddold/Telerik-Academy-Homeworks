namespace ReverseSentence
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	                                                    output
C# is not C++, not PHP and not Delphi!	                    Delphi not and PHP, not C++ not is C#!*/
    
    class ReversesWordsInSentence
    {
        static void Main()
        {
            Console.Write("Please enter your sentence: ");
            string sentence = Console.ReadLine();

            //string sentence = "C# is not C++, not PHP and not Delphi!";

            string regexSplit = @"\s+?|\.\s?|\s+?|\!\s?|\s+?|\,\s?|\s+?|\?\s?|\s+?|\-\s?|\;|\s+?";

            Stack words = new Stack();
            Queue separators = new Queue();

            string[] splitSentenceWords = Regex.Split(sentence, regexSplit);

            // Adding each word in the Stack 
            foreach (var word in splitSentenceWords)
            {
                if (word != "")
                {
                    words.Push(word);
                }
            }

            // Adding each separator in the Queue
            foreach (var separator in Regex.Matches(sentence, regexSplit))
            {
                separators.Enqueue(separator);
            }

            StringBuilder reversed = new StringBuilder();

            while (words.Count > 0 && separators.Count > 0)
            {
                reversed.Append(words.Pop());
                reversed.Append(separators.Dequeue());
            }

            Console.WriteLine("The sentence before the reverse: {0}", sentence);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The sentence after the reverse: {0}", reversed);
            Console.WriteLine(new string('-', 50));
        }
    }
}
