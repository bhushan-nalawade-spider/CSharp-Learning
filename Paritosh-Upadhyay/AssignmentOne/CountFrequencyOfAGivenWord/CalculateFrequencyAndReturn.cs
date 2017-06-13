using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFrequencyOfAGivenWord
{
    class CalculateFrequencyAndReturn
    {
        public int CalculateFrequency(string enteredSentence, string enteredWord)
        {
            int frequency = 0;

            string[] str = (enteredSentence).Split(' ', '.', '!', ';');

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals(enteredWord))
                {
                    frequency++;
                }
            }
            return frequency;
        }
    }
}
