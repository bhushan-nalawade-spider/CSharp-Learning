using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExcercises
{
    class Ex2_PrimeFromFile
    {
        internal string ReadFromFile(string fileName)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");

            
            string text = string.Empty;
            try
            {
                var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    Console.WriteLine("contents of file: " + text);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please check {0} file existance..", fileName);
            }

            return text;
        }

        public void PrintPrimeNumbersFromFile(string numbers)
        {
            // string filepath = "D:\\MyDir\\numbers.csv";
            //Console.WriteLine("-------------------------------------------------------------------------------");
            if (numbers == "")
            {
                Console.WriteLine("empty contents, exiting...");
                return;
            }
            string[] numberArray = numbers.Split(',');
            int[] primeArray = new int[numberArray.Length];
            int i = 0; int primeIndex = -1;
            foreach (string number in numberArray)
            {
                i = int.Parse(number.Trim());
                //Console.WriteLine( "numberArray[{0}]: {1}",i++,  int.Parse(number.Trim()));
                if (Check_Prime(i))
                {
                    primeArray[++primeIndex] = i;
                }
            }

            if (primeIndex >= 0)
            {
                Console.Write("prime numbers from file: ");
                

                for (int pi=0; pi<= primeIndex;  pi++)
                {
                    Console.Write(primeArray[pi] + " ");
                }
            }
            else
            {
                Console.Write("No prime numbers in the file ");
            }
            Console.WriteLine(); 
        }

        private bool Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
    }
}
