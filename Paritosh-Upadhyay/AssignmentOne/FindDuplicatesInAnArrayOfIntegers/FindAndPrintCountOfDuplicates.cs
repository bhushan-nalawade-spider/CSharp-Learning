using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesInAnArrayOfIntegers
{
    class FindAndPrintCountOfDuplicates
    {
        public void PrintCountOfDuplicates(int[] arrayOfIntegers, int lengthOfArray)
        {
            int countOfDuplicates = 0;
            for (int i = 0; i < lengthOfArray; i++)
            {
                for (int j = i + 1; j < lengthOfArray; j++)
                {
                    if (arrayOfIntegers[i] == arrayOfIntegers[j])
                    {
                        countOfDuplicates++;
                        break;
                    }
                }
            }

            Console.WriteLine("\nNumber of duplicate elements found in the array is : {0}\n", countOfDuplicates);
        }
    }
}
