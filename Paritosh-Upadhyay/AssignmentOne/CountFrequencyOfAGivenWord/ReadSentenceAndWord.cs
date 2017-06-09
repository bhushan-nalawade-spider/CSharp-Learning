using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFrequencyOfAGivenWord
{
    class ReadSentenceAndWord
    {
        public string enteredSentence;
        public string enteredWord;

        public void ReadString()
        {
            Console.WriteLine("Enter the sentence: ");
            enteredSentence = Console.ReadLine();

            Console.WriteLine("Enter the word: ");
            enteredWord = Console.ReadLine();
        }
    }
}
