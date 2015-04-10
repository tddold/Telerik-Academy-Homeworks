namespace ParseURL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and 
extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	                                                                Information                         
http://telerikacademy.com/Courses/Courses/Details/212	            [protocol] = http 
                                                                    [server] = telerikacademy.com 
                                                                    [resource] = /Courses/Courses/Details/212*/
    class ParseUrlAddress
    {
        static void Main()
        {
            Console.Write("Please enter your URL: ");
            string text = Console.ReadLine();

            Uri input = new Uri(text);

            Console.WriteLine("[protocol] = {0}", input.Scheme);
            Console.WriteLine("[server] = {0}", input.Host);
            Console.WriteLine("[resource] = {0}", input.AbsolutePath);
        }
    }
}
