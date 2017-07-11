using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAndSmallestFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputFromUser = GetInputFromUser();
            int [] sortedArray = SortElement(inputFromUser);
            Console.WriteLine('\n'+"lowest number of array is => {0}", sortedArray[0]);
            Console.WriteLine("highest number of array is => {0}", sortedArray[sortedArray.Length - 1]);
        }

        public static int[] GetInputFromUser()
        {

            int[] inputArray = null;
            try
            {
                Console.Write('\n' + "Enter the size of array => ");
                int sizeOfArray = int.Parse(Console.ReadLine());
                inputArray = new int[sizeOfArray];
                for (int index = 0; index < sizeOfArray; index++)
                {
                    Console.Write("Element {0}  =>", index);
                    inputArray[index] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("invalid input,program terminated");
                Environment.Exit(0);
            }
           
            return inputArray;
        }

        public static int[] SortElement(int[] inputArray)//Selection sort
        {
            for (int indexOfArray = 0; indexOfArray < inputArray.Length - 1; indexOfArray++)
            {
                int position = indexOfArray;

                for (int index = indexOfArray + 1; index < inputArray.Length; index++)
                {
                    if (inputArray[position] > inputArray[index])
                    {
                        position = index;
                    }
                }
                int temp = inputArray[position];
                inputArray[position] = inputArray[indexOfArray];
                inputArray[indexOfArray] = temp;
            }
            Console.Write("Sorted array is ");
            foreach (int t in inputArray)
            {
                Console.Write(t + " ");
            }
            return inputArray;
        }
    }
}
