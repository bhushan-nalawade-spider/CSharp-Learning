using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to find the largest and the smallest number from an array of 10 numbers.");

            Calculate calc = new Calculate();
            calc.CalculateLargestAndSmallest();

            PrintResult print = new PrintResult(calc.HighestNumber, calc.LowestNumber);
            print.PrintOutputOnConsole();
        }
    }
}
