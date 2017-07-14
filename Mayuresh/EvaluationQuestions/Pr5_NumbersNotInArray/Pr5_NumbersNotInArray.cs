using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_NumbersNotInArray
{
    class Pr5_NumbersNotInArray
    {
        static void Main(string[] args)
        {
            int arraySize = 0, minRange = 0, maxRange = 0;
            Console.WriteLine("Enter the array size: ");

            arraySize = getInteger();

            Console.Write("Enter the range \nMin.: ");
            minRange = getInteger();
            
            Console.Write("Max.: ");
            maxRange = getInteger();

            int[] sampleArray = createArray(arraySize);

            bool matches = false;

            for (int i = minRange; i <= maxRange; i++)
            {
                foreach (int j in sampleArray)
                {
                    if (i == j)
                    {
                        matches = true;
                        break;
                    }
                    else
                        matches = false;
                    
                }
                
                if(!matches)
                    Console.Write(i + ",\t");
            }

            Console.Read();

        }

        private static int getInteger()
        {
            int reqInt = 0;
            try
            {
                reqInt = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return reqInt;
        }

        private static int[] createArray(int arraySize)
        {
            
            int[] numberArray = new int[arraySize];

            for (int number = 0; number < arraySize; number++)
            {
                Console.WriteLine("Enter number " + (number + 1) + " :");
                int enteredNum = getInteger();
                numberArray[number] = enteredNum;                
            }

            numberArray = sortArray(numberArray);

            for (int number = 0; number < arraySize; number++)
            {
                Console.WriteLine("Show number " + (number + 1) + " : " +numberArray[number]);
            }

            return numberArray;
        }

        private static int[] sortArray(int[] sampleArray)
        {
            int temp = 0;
            for (int i = 0; i < sampleArray.Length; i++)
            {
                for (int j = i; j < sampleArray.Length; j++)
                {
                    if (sampleArray[i] > sampleArray[j])
                    {
                        temp = sampleArray[i];
                        sampleArray[i] = sampleArray[j];
                        sampleArray[j] = temp;
                    }
                }

            }
            
            return sampleArray;
        }
    }
}
