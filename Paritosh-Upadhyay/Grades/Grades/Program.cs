using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Speak("Hello Paritosh");

            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average Grade",stats.AverageGrade);
            WriteResult("Highest Grade", stats.HighestGrade);
            WriteResult("Lowest Grade", stats.LowestGrade);
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine(description+": "+result);
            //Console.WriteLine("{0}: {1}", description, result);
            Console.WriteLine($"{description}: {result:F2}");
        }

       
    }
}
