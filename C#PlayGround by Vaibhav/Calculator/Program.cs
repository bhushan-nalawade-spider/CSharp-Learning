using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorProgram
    {
        private static void Main(string[] args)
        {
            int opt = DisplayMenu();

            if ((opt < 6) || (opt > 0))
            {
                try
                {
                    Console.WriteLine("Enter First Digit => ");
                    int firstNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Second Digit => ");
                    int secondNumber = int.Parse(Console.ReadLine());

                    Add(opt, firstNumber, secondNumber);
                    Sub(opt, firstNumber, secondNumber);
                    Multiplication(opt, firstNumber, secondNumber);
                    Division(opt, firstNumber, secondNumber);
                }
                catch (Exception ex)
                {
                    if (ex!=null)
                        Console.WriteLine("Invalid Input! terminating the program...");
                }
               
            }
        }

        public static int DisplayMenu()
        {   
            int option=0;
            Console.Clear();
            Console.WriteLine("******Vaibhav's Cal-cu-lator******" + '\n' + '\n' + '\n');
            Console.WriteLine("Please Enter Option Number to Perform Calculation");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            if (!int.TryParse(Console.ReadLine(), out option) || option > 5 || option < 0)
            {
                Console.WriteLine("Invalid input. CalculatorProgram Terminated");
                Environment.Exit(0);
            }
            if (option == 5)
            {
                Console.WriteLine("You pressed '5' . Bye Bye exiting from program");
                Environment.Exit(0);
            }
            return option;
        }

        public static void Add(int option, int firstNumber, int secondNumber)
        {
            int result;
            if (option == 1)
            {
                result = (firstNumber) + (secondNumber);
                Console.WriteLine("Result of {0} + {1} => {2}", firstNumber, secondNumber, result);
                Console.ReadLine();
            }
        }

        public static void Sub(int option, int firstNumber, int secondNumber)
        {
            int result;
            if (option == 2)
            {
                result = (firstNumber) - (secondNumber);
                Console.WriteLine("Result of {0} - {1} => {2}", firstNumber, secondNumber, result);
                Console.ReadLine();
            }
        }

        public static void Multiplication(int option, int firstNumber, int secondNumber)
        {
            int result;
            if (option == 3)
            {
                result = (firstNumber) * (secondNumber);
                Console.WriteLine("Result of {0} * {1} => {2}", firstNumber, secondNumber, result);
                Console.ReadLine();
            }
        }

        public static void Division(int option, int firstNumber, int secondNumber)
        {
            int result;
            if (option == 4)
            {
                result = (firstNumber) / (secondNumber);
                Console.WriteLine("Result of {0} / {1} => {2}", firstNumber, secondNumber, result);
                Console.ReadLine();
            }
        }

    }
}
