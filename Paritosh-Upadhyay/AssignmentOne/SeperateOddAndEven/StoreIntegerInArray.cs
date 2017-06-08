using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateOddAndEven
{
    class StoreIntegerInArray
    {
        public int[] storeIntegers(int lengthOfArray)
        {
            int[] arrayOfIntegers = new int[50];

            for (int i = 0; i < lengthOfArray; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }

            return arrayOfIntegers;
        }
    }
}
