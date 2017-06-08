using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DisplayMenuAndInputChoice
    {
        public void Display()
        {
            Console.WriteLine("\n********** Menu **********");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
        }

        public int choice()
        {
            int option = 0;
            Console.Write("\nWhat operation do you want to perform? ");
            try
            {
                 option = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bad entry...");
                Environment.Exit(0);
            }
            return option;
        }
    }
}
