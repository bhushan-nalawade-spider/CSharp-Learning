using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrintResult : Calculate
    {
        public PrintResult(float highestNumber, float lowestNumber)
        {
            HighestNumber = highestNumber;
            LowestNumber = lowestNumber;
        }

        public void PrintOutputOnConsole()
        {
            Console.WriteLine("Highest Number: {0}", HighestNumber);
            Console.WriteLine("Lowest Number: {0}", LowestNumber);
        }
    }
}
