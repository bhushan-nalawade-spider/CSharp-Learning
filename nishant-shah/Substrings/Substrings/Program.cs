using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the Input String:-");
           var str = Console.ReadLine().ToCharArray();
           StringBuilder substrings = new StringBuilder();
           String tempString = String.Empty;
            for(int i=0; i<str.Count();i++)
            {
                substrings.Append(str[i] + ",");
                tempString = str[i].ToString();
                for(int j=i+1;j<str.Count();j++)
                {
                   tempString = tempString+str[j];
                   substrings.Append(tempString + ",");
                }
            }

            substrings.Replace(",", "", substrings.Length - 1, 1);
            Console.WriteLine(substrings.ToString());
            Console.ReadLine();
        }
    }
}
