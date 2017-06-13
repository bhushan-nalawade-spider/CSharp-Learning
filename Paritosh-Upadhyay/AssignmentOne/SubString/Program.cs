using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to list all possible unique substrings in a given String.");

            Console.Write("Enter a String: ");
            string enteredString = Console.ReadLine();

            for (int length = 1; length < enteredString.Length; length++)
            {
                for (int start = 0; start <= enteredString.Length - length; start++)
                {
                    string substring = enteredString.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
