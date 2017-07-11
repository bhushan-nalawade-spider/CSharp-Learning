using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlap
{
    class FindOverlapExists
    {
        static void Main(string[] args)
        {
            int[] firstRange = GetRange();
            int[] secondRange = GetRange();
            CheckOverlapExists(firstRange, secondRange);
           
        }

        public static int[] GetRange()
        {
            int[] arrayRange = new int[] { };
            try
            {
                Console.Write('\n' + "Range starts from => ");
                int startingIndex = Int32.Parse(Console.ReadLine());
                Console.Write("Range ends from => ");
                int endingIndex = Int32.Parse(Console.ReadLine());
                int arraySize = endingIndex - startingIndex + 1;
                arrayRange = new int[arraySize];
                for (int indexOfRange = 0; indexOfRange < arraySize; indexOfRange++)
                {
                    arrayRange[indexOfRange] = startingIndex;
                    startingIndex = startingIndex + 1;
                    Console.Write(arrayRange[indexOfRange] + " ");
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                    Console.WriteLine("Please enter valid values..");
                System.Environment.Exit(0);
            }
            return arrayRange;
        }


        public static void CheckOverlapExists(int [] firstRange, int [] secondRange)
        {
            int startA = firstRange[0];
            int endA = firstRange[firstRange.Length - 1];
            int startB= secondRange[0];
            int endB = secondRange[secondRange.Length - 1];

            if (((startA <= startB) && (endA >= startB)) || ((startA <= startB) && (endA >= endB)) ||
                ((startA == startB) && (endA == endB)) ||
                ((startA <= endB) && (endA >= endB)) || ((startA >= startB) && (endA <= endB)))
            {
                Console.WriteLine('\n'+" Overlap exists!!");
            }
            else
            {
                Console.WriteLine('\n'+ "Range doesnot Overlap !!");
            }   

        }

    }
}
