using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesInAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[50];
            int lengthOfArray = 0;

            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to display count of duplicate integers in an array of integers.");

            Console.Write("Enter the number of elements to be stored in the array: ");
            try
            {
                lengthOfArray = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bad Entry...\n");
                Environment.Exit(0);
            }

            StoreIntegerInArray storenumbers = new StoreIntegerInArray();
            integers = storenumbers.storeIntegers(lengthOfArray);

            FindAndPrintCountOfDuplicates print = new FindAndPrintCountOfDuplicates();
            print.PrintCountOfDuplicates(integers, lengthOfArray);
        }
    }
}
