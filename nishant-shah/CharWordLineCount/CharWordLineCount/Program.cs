using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharWordLineCount
{
    class Program
    {
        static void Main(string[] args)
        {

            String text = ReadTextFile();
            GetLineAndWordCount(text);
            GetcharCount(text);
            Console.ReadLine();
        }

        private static string ReadTextFile()
        {
            string text = String.Empty;
            try
            {

                var fileStream = new FileStream(@"../../../File/Input.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some error in reading the text file:- " + ex.ToString());
            }
            return text;
        }

        private static int GetLineAndWordCount(String text)
        {
            int wordCount = 0;
            try
            {
                var lines = text.Split(new String[] { "\n" }, StringSplitOptions.None);

                Console.WriteLine("The number of lines in the input is:- " + lines.Count());

                foreach (String line in lines)
                {
                    var wordsInLine = line.Split(' ');
                    wordCount = wordCount + wordsInLine.Count();


                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some Error occurred in determining the Word Count:- " + ex.ToString());
               
            }
            Console.WriteLine("Total number of words in the text is :- "+ wordCount);
            return wordCount;
        }


        private static int GetcharCount(String text)
        {
            int charCount = 0;
            try
            {
                
                foreach (char c in text)
                {
                    charCount = charCount + 1;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some Error occurred in determining the char Count:- " + ex.ToString());

            }
            Console.WriteLine("The character count in the text is:- " + charCount);
            return charCount;
        }
    }
}
