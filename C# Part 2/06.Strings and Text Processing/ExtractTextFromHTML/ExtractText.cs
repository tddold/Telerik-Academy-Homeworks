namespace ExtractTextFromHTML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    /*Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">TelerikAcademy</a> aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.*/
    class ExtractText
    {
        static void Main()
        {
            Console.WriteLine("Please enter your HTML:");
            string htmlFile = Console.ReadLine();

            string regex = @"(?<=^|>)[^><]+?(?=<|$)";

            MatchCollection result = Regex.Matches(htmlFile, regex);

            Console.WriteLine("\nResult: ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
