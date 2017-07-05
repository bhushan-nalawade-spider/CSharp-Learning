using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_WordsLinesChars
{
    class Pr4_WordsLinesChars
    {
        static void Main(string[] args)
        {
            String testPara = "This has happened to me several times, but I'm not sure how to report it. \n" 
          + "So I repeated the lesson immediately to practice the other words, and the same thing happened again! I get that heureux has an odd declension pattern, but I feel that the other words barely got any practice. \n"
          + "For instance, today I did lesson one of Adjectives 4 in French, and I got about 10 sentences in a row with 'heureux'. ";

            int wordCount = countWords(testPara);
            int lineCount = countLines(testPara);
            int charCount = countChars(testPara);

            Console.WriteLine("There are " + lineCount + " Lines, " + wordCount + " Words, and " + charCount + " chars in the paragraph \n" +testPara);
            Console.Read();
        }

        private static int countChars(string testPara)
        {
            return testPara.Length;
        }

        private static int countLines(string testPara)
        {
            String[] lineArray = testPara.Split('\n');
            return lineArray.Length;
        }

        private static int countWords(string testPara)
        {
            String[] wordsInRecString = testPara.Split(' ');

            int count = wordsInRecString.Length;

            return count;
        }
    }
}
