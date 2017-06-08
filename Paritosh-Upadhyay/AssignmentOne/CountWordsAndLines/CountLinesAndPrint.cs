using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsAndLines
{
    class CountLinesAndPrint
    {
        public void CountNumberOfLines(string enteredSentence)
        {
            Console.WriteLine("Number of Lines: {0}", enteredSentence.Split('\n').Length);
        }
    }
}
