using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float numberOne = 0;
            float numberTwo = 0;

            InputNumbers input = new InputNumbers();
            numberOne = input.InputNum("first");
            numberTwo = input.InputNum("second");

            DisplayMenuAndInputChoice menu = new DisplayMenuAndInputChoice();
            menu.Display();
            int option = menu.choice();
            
            Calculator calc = new Calculator();
            calc.operation(option, numberOne, numberTwo);
           
            Console.WriteLine("\n");
        }
    }
}
