using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to print binary triangle.");

            SizeOfBinaryTriangle getSize = new SizeOfBinaryTriangle();
            int NumberOfRows = getSize.NumberOfRowsForBinaryTriangle();

            BinaryTriangle print = new BinaryTriangle();
            print.PrintBinaryTriangleOnConsole(NumberOfRows);
        }
    }
}
