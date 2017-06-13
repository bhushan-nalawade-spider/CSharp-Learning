using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequenceyOfWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Sentence:-");
            String sentence = Console.ReadLine();
            Console.WriteLine("Enter the Word for Frequency count:-");
            String word = Console.ReadLine();

            var words = sentence.Split(' ');
            int theCount = 0;
            foreach(string str in words)
            {
                if (str.Trim().ToUpper().Equals("THE"))
                    theCount = theCount + 1;
            }

            Console.WriteLine("The count of word the in the sentence is:- " + theCount);
            Console.ReadLine();
        }
    }
}
