using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculate
    {
        public float LowestNumber;
        public float HighestNumber;

        public void CalculateLargestAndSmallest()
        {
            float[] ArrayToStoreNumbers = new float[10];

            for (int EnteredNumber = 0; EnteredNumber < 10; EnteredNumber++)
            {
                Console.WriteLine("Enter {0} number:", (EnteredNumber + 1));
                ArrayToStoreNumbers[EnteredNumber] = float.Parse(Console.ReadLine());
            }

            LowestNumber = ArrayToStoreNumbers[0];
            HighestNumber = ArrayToStoreNumbers[0];

            for (int EnteredNumber = 0; EnteredNumber < 10; EnteredNumber++)
            {
                if (ArrayToStoreNumbers[EnteredNumber] > HighestNumber)
                {
                    HighestNumber = ArrayToStoreNumbers[EnteredNumber];
                }
                else if (ArrayToStoreNumbers[EnteredNumber] < LowestNumber)
                {
                    LowestNumber = ArrayToStoreNumbers[EnteredNumber];
                }

            }

        }
    }
}
