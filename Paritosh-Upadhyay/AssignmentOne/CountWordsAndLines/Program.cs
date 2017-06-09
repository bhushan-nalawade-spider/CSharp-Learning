using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsAndLines
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to count number of words and lines in a given sentence.");

            ReadSentence read = new ReadSentence();
            read.ReadString();

            CountWordsAndPrint cntWord = new CountWordsAndPrint();
            cntWord.CountNumberOfWords(read.enteredSentence);

            CountLinesAndPrint cntLine = new CountLinesAndPrint();
            cntLine.CountNumberOfLines(read.enteredSentence);
        }
    }
}
