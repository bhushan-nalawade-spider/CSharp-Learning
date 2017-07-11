using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    //4. Program to simulate calculator
    //  e.g it takes numbers and asks for operator

namespace Calculator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter two numbers: ");
            float FirstNumber = float.Parse(Console.ReadLine());
            float SecondNumber = float.Parse(Console.ReadLine());
            Console.Write("Enter oeprator: ");
            String Operator = Console.ReadLine();
            switch (Operator)
            {
                case "+":
                    Console.WriteLine($"Addition of {FirstNumber} and {SecondNumber}: {add(FirstNumber, SecondNumber)}");
                    break;
                case "-":
                    Console.WriteLine($"Subtraction of {FirstNumber} from {SecondNumber}: {subtraction(FirstNumber, SecondNumber)}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplication of {FirstNumber} and {SecondNumber}: {mulitplication(FirstNumber, SecondNumber)}");
                    break;
                default :
                    Console.WriteLine($"You have entered wrong operator {Operator}");
                    break;

            }
            Console.ReadKey();

        }

        private static float add(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
        private static float subtraction (float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }
        private static float mulitplication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
