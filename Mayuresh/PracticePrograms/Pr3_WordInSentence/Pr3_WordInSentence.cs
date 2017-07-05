using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3_WordInSentence
{
    class Pr3_WordInSentence
    {
        static void Main(string[] args)
        {
            String refString = "I got the duck like 5 times, the mouse 5 times too, and the pet, the fly and the horse only once." 
            + "When I try to go back to repeat the lesson, I still get the same words, and I still have reviewed 'pet' only once.";

            String wordToBeCounted = "the";
            int wordCount = calculateWordInString(refString, wordToBeCounted);

            Console.WriteLine("The word '" +wordToBeCounted+ "' is present in the string for " + wordCount + " times.");
            Console.Read();
        }

        private static int calculateWordInString(String recString, String reqWord)
        {
            int count = 0;
            String[] wordsInRecString = recString.Split(' ');

            foreach (String word in wordsInRecString)
            {
                if (word.Equals(reqWord))
                    count++;
            }

            return count;
        }
    }
}
