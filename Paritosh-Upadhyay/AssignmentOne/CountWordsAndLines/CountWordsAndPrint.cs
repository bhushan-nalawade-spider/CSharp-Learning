using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordsAndLines
{
    class CountWordsAndPrint
    {
        public void CountNumberOfWords(string enteredSentence)
        {
            StringBuilder word = new StringBuilder();
            foreach (char c in enteredSentence)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c == ' '))
                {
                    word.Append(c);
                }
            }
            string[] str = word.ToString().Trim().Split(' ');

            Console.WriteLine("Number of Words: {0}",str.Length);
        }
    }
}
