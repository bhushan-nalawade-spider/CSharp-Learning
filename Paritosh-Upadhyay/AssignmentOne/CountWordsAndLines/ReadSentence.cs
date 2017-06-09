using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsAndLines
{
    class ReadSentence
    {
        public string enteredSentence;
        public void ReadString()
        {
            Console.WriteLine("Enter the sentence: ");
            enteredSentence = Console.ReadLine();
        }
    }
}
