using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public void operation(int option, float numberOne, float numberTwo)
        {
            float result = 0;

            switch (option)
            {
                case 1:
                    result = add(numberOne, numberTwo);
                    Console.WriteLine("\nAddition of {0} and {1} is: {2}", numberOne, numberTwo, result);
                    break;

                case 2:
                    result = sub(numberOne, numberTwo);
                    Console.WriteLine("\nSubstraction of {1} from {0} is: {2}", numberOne, numberTwo, result);
                    break;

                case 3:
                    result = mul(numberOne, numberTwo);
                    Console.WriteLine("\nMultiplication of {0} and {1} is: {2}", numberOne, numberTwo, result);
                    break;

                case 4:
                    result = div(numberOne, numberTwo);
                    Console.WriteLine("\nDivision of {0} by {1} is: {2}", numberOne, numberTwo, result);
                    break;

                default:
                    Console.WriteLine("\nInvalid...");
                    break;
            }
        }

        public float add(float numberOne, float numberTwo)
        {
            float result = (numberOne + numberTwo);
            return result;
        }

        public float sub(float numberOne, float numberTwo)
        {
            float result = (numberOne - numberTwo);
            return result;
        }

        public float mul(float numberOne, float numberTwo)
        {
            float result = (numberOne * numberTwo);
            return result;
        }

        public float div(float numberOne, float numberTwo)
        {
            float result = (numberOne / numberTwo);
            return result;
        }

    }
}
