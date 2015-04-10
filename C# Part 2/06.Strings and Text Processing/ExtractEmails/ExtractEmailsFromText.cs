namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    

/*Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
    class ExtractEmailsFromText
    {
        static void Main()
        {
            string text =  @"I have a lots of emails. pikachu@yahoo.com is one of them but i don't use it, because it was hacked by telerik ninja. " + 
                            "wizard_994@abv.bg and waka-waka@hotmail.co.uk are my favourites";

            string regex = @"[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";

            MatchCollection emails  = Regex.Matches(text, regex);

            Console.WriteLine(text);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("All emails from the text: \n");
            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
