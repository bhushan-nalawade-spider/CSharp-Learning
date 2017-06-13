using System;

namespace PracticeExcercises
{
    internal class Ex3_WordFrequency
    {
        public Ex3_WordFrequency()
        {
        }

        internal void FindWordFrequency()
        {
            Console.Write("Enter the string: ");
            string text = Console.ReadLine();

            Console.Write("Enter the pattern: ");
            string pattern = Console.ReadLine();

            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("No of times \"{0}\" appeared : {1}", pattern, count);
        }
    }
}
