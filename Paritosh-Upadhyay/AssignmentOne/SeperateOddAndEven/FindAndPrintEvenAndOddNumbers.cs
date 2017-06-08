using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateOddAndEven
{
    class FindAndPrintEvenAndOddNumbers
    {
        int[] evenArray = new int[50];
        int[] oddArray = new int[50];
        int even = 0;
        int odd = 0;

        public void FindEvenOdd(int[] arrayOfIntegers, int lengthOfArray)
        {

            for (int i = 0; i < lengthOfArray; i++)
            {
                if ((arrayOfIntegers[i] % 2) == 0)
                {
                    evenArray[even] = arrayOfIntegers[i];
                    even++;
                }
                else
                {
                   oddArray[odd] = arrayOfIntegers[i];
                    odd++;
                }
            }
        }

        public void PrintEven()
        {
            Console.Write("\nEven Numbers: ");
            for (int temp = 0; temp < even; temp++)
            {
                Console.Write(evenArray[temp] + " ");
            }
            Console.WriteLine("\n");
        }

        public void PrintOdd()
        {
            Console.Write("\nOdd Numbers: ");
            for (int temp = 0; temp < odd; temp++)
            {
                Console.Write(oddArray[temp] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
