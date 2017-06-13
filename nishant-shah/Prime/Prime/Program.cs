using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {

        static List<int> nos = new List<int>();
       
        static void Main(string[] args)
        {
            ReadCSVFile();
            IdentifyPrimeInList();
        }

        private static void ReadCSVFile()
        {
            using (var fs = File.OpenRead(@"../../../TestData/Numbers.csv"))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[0].Equals("Numbers"))
                        continue;
                    nos.Add(int.Parse(values[0]));
                }
            }
        }

        private static void IdentifyPrimeInList()
        {
            for(int count =0; count<nos.Count;count++)
            {
                
                if(IsPrime(nos[count]) || nos[count].Equals(1))
                    Console.WriteLine(nos[count] + " is :- NOT PRIME");
                else
                    Console.WriteLine(nos[count] + " is :-  PRIME");
            }

            Console.ReadLine();
        }

        private static Boolean IsPrime(int no)
        {
            for (int i = 2; i < no;i++ )
            {
                if (no % i == 0)
                    return true;
            }
                return false;
        }
    }
}
