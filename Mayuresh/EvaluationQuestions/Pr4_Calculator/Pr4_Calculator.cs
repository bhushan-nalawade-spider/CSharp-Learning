using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_Calculator
{
    class Pr4_Calculator
    {
        static void Main(string[] args)
        {
            double value1 = 0, value2 = 0, result = 0;
            String operation = "";

            Console.WriteLine("Enter the first value");
            try
            {
                value1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            while (!(operation.Equals("exit")))
            {
                Console.WriteLine("Enter the next value");
                try
                {
                    value2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                     Console.WriteLine(e.StackTrace);
                }

                Console.WriteLine("Enter Operation - \t\n'add' for Addition; \t\n'sub' for Subtraction;" +
                        "\t\n'multiply' for Multiplication; \t\n'div' for Division; \t\n'perc' for percentages;"+
                        "\t\n'rem' for Remainder after devision; \t\n'exit' to quit the program");

                try
                {
                    operation = Console.ReadLine();
                }
                catch (Exception e)
                {
                     Console.WriteLine(e.StackTrace);
                }

                if(operation.Equals("exit"))
                    continue;

                try
                {
                    result = performOperation(value1, value2, operation);
                }
                catch (Exception e)
                {
                     Console.WriteLine(e.StackTrace);
                }

                Console.WriteLine("Result of the operation is: " + result);
                value1 = result;
            }

            Console.WriteLine("The Final Result is: " + result);
                
            Console.ReadLine();
                        
        }

        private static double performOperation(double value1, double value2, String operation)
        {
            switch(operation)
            {
                case "add":
                    return value1 + value2;

                case "sub":
                    return value1 - value2;

                case "multiply":
                    return value1 * value2;
                    
                case "div":
                    return value1 / value2;
                    
                case "perc":
                    return value1 * value2 / 100;

                case "rem":
                    return value1 % value2;

                default:
                    Console.WriteLine("Invalid Operation. The program will not do anything. Please enter correct value next time.");
                    break;
            }
            return value1;
        }
    }
}
