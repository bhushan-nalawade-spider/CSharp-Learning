using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************
/*  
 *  EX-01: Find largest and smallest from an array of 10 numbers- program
 *  
 **************************************************************************
 */
namespace PracticeExcercises
{
    public class Ex1_ArrayNumbers
    {   
        public static int[] AddIntegersToArrray()
        {
            //Get the array of integers from user
            Console.WriteLine("Input an array of 5 integers : ");
            int[] IntArray = new int[5]; //Convert.ToInt32(Console.ReadLine())

            //Store these into an array
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                IntArray[i] = int.Parse(Console.ReadLine());
            }
            return IntArray;
        }


        public static void FindLargestSmallestFromAnArray(int[] IntArray)
        {
            //Declare largest and smallest numbers as first elment of array
            int smallestNumber = IntArray[0];
            int largestNumber = IntArray[0];

            //Loop thru array all elements of array
            for (int i = 0; i < IntArray.Length; i++)
            {
                //Compare current element with next element if larger, store as largest number
                if (IntArray[i] > largestNumber)
                    largestNumber = IntArray[i];
                //if smaller, store as smallest number
                else if (IntArray[i] < smallestNumber)
                    smallestNumber = IntArray[i];
            }

            //Print largest and smallest numbers
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Largest element in the array is {0}", largestNumber);
            Console.WriteLine("Smallest element in the array is {0}", smallestNumber);

            //Console.ReadKey();
        }
    }
}
