namespace ReplaceTags
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 
*/
    class ReplaceTagsInDocument
    {
        static void Main()
        {
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            string start = "[URL=";
            string bracketClose = "]";
            string end = "[/URL]";

            for (int i = 0; i <= input.Length - 9; i++)
            {
                if (input.Substring(i, 9) == "<a href=\"")
                {
                    input = input.Replace("<a href=\"", start);
                }

                if (input.Substring(i, 2) == "\">")
                {
                    input = input.Replace("\">", bracketClose);
                }

                if (input.Substring(i, 4) == "</a>")
                {
                    input = input.Replace("</a>", end);
                }
            }
            Console.WriteLine(input);

        }
    }
}
