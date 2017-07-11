using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleSubString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string getString = GetString();
            PossibleSubstring(getString);
        }

        public static String GetString()
        {
            String inputStringFromUser = "";
            try
            {
                Console.Write("Please Enter the string: ");
                inputStringFromUser = Console.ReadLine();

            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    Console.WriteLine("Invalid input !!");
                    Environment.Exit(0);
                }
            }

            return inputStringFromUser;
        }

        public static void PossibleSubstring(String getString)
        {
            string subString = "";
            for (int count = 0; count < getString.Length; count++)
            {
                for (int index = count; index < getString.Length; index++)
                {
                    subString = subString + getString[index];
                    Console.WriteLine(subString);
                }
                subString = "";
            }
        }
    }
}
