using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTHeNumberOfWords
{

    class Program
    {
        static void Main(string[] args)
        {
//            String inputStringFromUser = GetString();
            String inputStringFromUser = " This has happened to me several times, but I'm not sure how to report it." +
                                         "\n" +
                                         "So I repeated the lesson immediately to practice the other words, and the same thing happened again!I get that" +
                                         "heureux has an odd declension pattern, but I feel that the other words barely got any practice." +
                                         "\n" +
                                         "For instance, today I did lesson one of Adjectives 4 in French, and I got about 10 sentences in a row with" +
                                         "heureux.";

            Console.WriteLine(inputStringFromUser);
            GetTheFrequency(inputStringFromUser);
        }


        public static void GetTheFrequency(String getString)
        {
            string[] splitLines = getString.Split(Environment.NewLine.ToCharArray());
            Console.WriteLine("total number of lines are => {0}",splitLines.Length);
            int space_count = 0;
            string new_text = "";
             foreach (string line in splitLines)
                    {
                            foreach (string av in line.Split(' '))
                            {
                                if (av == "")
                                {
                                    space_count++;
                                }
                                else
                                {
                                    new_text = new_text + av + ",";
                                }
                            }
                        }
            splitLines = new_text.Split(',');
            foreach (var splitLine in splitLines)
            {
                    Console.WriteLine(splitLine);
            }
            Console.WriteLine("total no. of words are  => {0}",splitLines.Length);
        }
    }
}
