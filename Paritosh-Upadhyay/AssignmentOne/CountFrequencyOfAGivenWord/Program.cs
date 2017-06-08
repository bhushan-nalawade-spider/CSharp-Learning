using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFrequencyOfAGivenWord
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to find the frequency of a given word in a sentence.");

            ReadSentenceAndWord read = new ReadSentenceAndWord();
            read.ReadString();

            CalculateFrequencyAndReturn freq = new CalculateFrequencyAndReturn();
            int frequency = freq.CalculateFrequency(read.enteredSentence, read.enteredWord);

            Console.WriteLine("Number of occurrence of the word '{0}' in given sentence is: {1}", read.enteredWord, frequency);
        }
    }
}
