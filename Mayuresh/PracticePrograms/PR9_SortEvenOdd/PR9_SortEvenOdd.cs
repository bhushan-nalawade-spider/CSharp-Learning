using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9_SortEvenOdd
{
    class PR9_SortEvenOdd
    {
        static int evenArraySize = 0;
        static int oddArraySize = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            int[] numberArray = new int[arraySize];

            for (int number = 0; number < arraySize; number++)
            {
                Console.WriteLine("Enter number " + (number + 1) + " :");
                string str = Console.ReadLine();

                int enteredNum = Convert.ToInt32(str);

                numberArray[number] = enteredNum;
            }

            foreach (int number in numberArray)
            {
                if (number % 2 == 0)
                    evenArraySize++;
                else
                    oddArraySize++;
            }

            int[] evenArray = new int[evenArraySize];
            int[] oddArray = new int[oddArraySize];
            int evenIndex = 0;
            int oddIndex = 0;

            foreach (int number in numberArray)
            {
                if (number % 2 == 0)
                {
                    evenArray[evenIndex] = number;
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = number;
                    oddIndex++;
                }
            }

            Console.WriteLine("Even array is: ");
            foreach (int number in evenArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Odd array is: ");
            foreach (int number in oddArray)
            {
                Console.WriteLine(number);
            }

            Console.Read();
        }

    }
}
