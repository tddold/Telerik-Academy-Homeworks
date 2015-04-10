/*Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceWholeWord
{
    class ReplaceWord
    {
        static void Main()
        {
            using (StreamWriter sw = new StreamWriter("output.txt"))
            {
                using (StreamReader sr = new StreamReader(@"..\..\..\someBooks.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, @"\bstart\b", "finish");
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("The text is located in output.txt");
            }
        }
    }
}
