using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr6_Substrings
{
    class Pr6_Substrings
    {
        static void Main(string[] args)
        {
            String sampleString = "abcde";

            Console.WriteLine("The string is: " + sampleString);
            for(int i = 0; i<sampleString.Length; i++)
            {
                String subString = sampleString.Substring(i);
                for (int j = 1; j <= subString.Length; j++)
                {
                    Console.WriteLine(sampleString.Substring(i,j));
                }
            }
            Console.Read();
        }
    }
}
