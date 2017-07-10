using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequecyOfTheWord
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputStringFromUser = GetString();
            String inputWord = GetWordToCountFrequency();
           int count = GetTheFrequency(inputStringFromUser, inputWord);
            Console.WriteLine(inputWord +" occurs " + count +" times");

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
                if (ex!= null)
                {
                    Console.WriteLine("Invalid input !!");
                    Environment.Exit(0);
                }
            }

            return inputStringFromUser;
        }

        public static String GetWordToCountFrequency()
        {
            Console.Write("Please Enter word for which you find the frequency: ");
            String inputWord = Console.ReadLine();
            return inputWord;
        }

        public static int GetTheFrequency(String getString, String getWord)
        {
            int count = 0;
            String[] keys = getString.Split(Convert.ToChar(" "));
            int lengthOfString = keys.Length;
            Console.WriteLine(lengthOfString);

            for ( int stringIndex=0; stringIndex < lengthOfString; stringIndex++)
            {
                if (keys[stringIndex] ==getWord)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
