using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class InputNumbers
    {
        public float InputNum(String str)
        {
            float number = 0;
            try
            {
                Console.Write("Enter {0} number: ", str);
                number = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bad entry...");
                Environment.Exit(0);
            }
            return number;
        }
    }
}
