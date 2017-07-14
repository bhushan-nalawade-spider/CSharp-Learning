using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr8_DuplicateElementsInArray
{
    class Pr8_DuplicateElementsInArray
    {
        static void Main(string[] args)
        {
            int arraySize = 0;

            //Console.WriteLine("Enter the size of the array: ");
            //arraySize = Convert.ToInt32(Console.ReadLine());

            // int[] sampleArray = createArray(arraySize);

            int[] sampleArray = { 1, 2, 3, 4, 1, 2, 5, 6, 7, 3, 1, 2, 1};

            int numberOfduplicateElements = CountDuplicateElementsInArray(sampleArray);

            Console.WriteLine("The number of duplicate elements is: " + numberOfduplicateElements);
            Console.ReadLine();
        }

        private static int CountDuplicateElementsInArray(int[] sampleArray)
        {
            int numberOfduplicateElements = 0;

            
            for (int i = 0; i < sampleArray.Length; i++ )
            {
                int T3 = 0;
                for (int j = i+1; j < sampleArray.Length; j++)
                {
                    int T1 = sampleArray[i];
                    int T2 = sampleArray[j];
                    
                    if (T3 != T2)
                    {
                        if (T1 == T2)
                        {
                            T3 = T2;
                            numberOfduplicateElements++;
                        }
                    }
                }

                Console.WriteLine("Loop1");
            }

            return numberOfduplicateElements;
        }

        private static int[] createArray(int arraySize)
        {
            int[] numberArray = new int[arraySize];

            for (int number = 0; number < arraySize; number++)
            {
                Console.WriteLine("Enter number " + (number + 1) + " :");
                string str = Console.ReadLine();

                int enteredNum = Convert.ToInt32(str);

                /*                while (enteredNum == 0)
                                {
                                    Console.WriteLine(" The number " + enteredNum + " is not allowed. Enter again:");

                                    str = Console.ReadLine();
                                    enteredNum = Convert.ToInt32(str);
                                }   */

                numberArray[number] = enteredNum;
            }

            return numberArray;
        }
    }
}
