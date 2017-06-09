using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadIntegers read = new ReadIntegers();

            read.InputSizeOfArray();

            read.InputNumberToArray();

            read.InputStartRange();

            read.InputEndRange();

            FindAndPrintUniqueNumbers findPrint = new FindAndPrintUniqueNumbers();

            findPrint.FindAndPrint();
        }
    }
}
