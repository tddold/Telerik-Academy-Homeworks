using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/

namespace ReadFileContents
{
    class ReadAndPrintFileContents
    {
        static void Main()
        {
            Console.Write("Enter file with full path: ");
            string path = Console.ReadLine();
            string readText = string.Empty;


            try
            {
                readText = File.ReadAllText(path);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Your path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Your path contains invalid characters or is blank.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is longer than system predefined.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File is not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("I/O error.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have permission to this file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("File is not supported.");
            }

            Console.WriteLine(readText);
        }
    }
}
