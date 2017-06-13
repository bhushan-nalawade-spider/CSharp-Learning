using System;
using System.IO;
using System.Text;

namespace PracticeExcercises
{
    public class Ex4_FileMetadata
    {
        public int CountLines(string lineFile)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            string s = CheckFile(lineFile);
            int count = 0;
            int position = 0;
            while ((position = s.IndexOf('\n', position)) != -1)
            {
                count++;
                position++;         // Skip this occurrence!
            }
            return count;
        }

        internal string CheckFile(string file)
        {
            string text = string.Empty;
            try
            {
                var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    Console.WriteLine("contents of file: " + text);

                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Please check {0} file existance..", file);
            }

            return text;
        }

        public long CountWordsFromFile(string wordFile)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            string text = CheckFile(wordFile);
            return CountWords(wordFile);

        }
        public long CountWords(string wordFile) 
        {

            StreamReader sr = new StreamReader(wordFile);

            long counter = 0;
            string delim = " ,.";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine(); 
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length; 
            }
            
            sr.Close();
            return counter;
        }
    }
}