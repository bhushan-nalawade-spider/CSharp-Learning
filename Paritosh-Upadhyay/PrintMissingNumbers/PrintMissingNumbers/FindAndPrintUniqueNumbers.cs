using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMissingNumbers
{
    class FindAndPrintUniqueNumbers : ReadIntegers
    {
        public void FindAndPrint()
        {
            Console.Write("Elements: ");

            for (int valueInRange = startRange; valueInRange <= endRange; valueInRange++)
            {
                int isElementPresent = 0;

                for (int elemOfArray = 0; elemOfArray <= count; elemOfArray++)
                {
                    if (valueInRange == arrayOfNumbers[elemOfArray])
                    {
                        isElementPresent = isElementPresent + 1;
                    }
                }

                if (isElementPresent == 0)
                {
                    Console.Write(valueInRange + " ");
                }
            }

            Console.WriteLine("\n");
        }
    }
}
