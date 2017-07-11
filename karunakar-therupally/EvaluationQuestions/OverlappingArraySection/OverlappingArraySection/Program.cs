using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingArraySection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st array ");
            int[] firstArray = EnterArray();

            Console.Write("Enter 2nd array ");
            int[] secondArray = EnterArray();

            PrintArray(firstArray);
            PrintArray(secondArray);

            Console.Write("Overlapping elements in above arrays: ");
            ElementsOverlapping(firstArray, secondArray);

            Console.ReadKey();
        }

        private static int[] EnterArray()
        {
            
            Console.Write("start and end elements: ");
            int firstElement = int.Parse(Console.ReadLine());
            int lastElement = int.Parse(Console.ReadLine());
            int arraySize = lastElement - firstElement + 1;
            int [] array = new int [arraySize];
            
            array  = AssignValuesToArray(array, firstElement);

            Console.WriteLine();
            return array;
        }

        private static int[] AssignValuesToArray(int[] array, int firstElement)
        {
            int value = firstElement;

            for (int i = 0; i < array.Length; i++, value++)
                array[i] = value;

            return array;
        }
        private static void PrintArray(int[] array)
        {

            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.Write("]");
            Console.WriteLine();
        }

        private static void ElementsOverlapping(int[] array, int [] array2)
        {
            
            int overLappedArraySize = 0;
            if (array2.Contains(array.Max()))
                overLappedArraySize = array.Max() - array2.Min() + 1;
            else
            {
                Console.WriteLine("Either 1st array or 2nd array is not correctly formed, no overlapping elements, exiting...");
                return;
            }
            int[] overLappedArray = new int[overLappedArraySize];
            int overLappedArrayIndex = 0;
            for (int i =0; i< array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i].Equals(array2[j]))
                        overLappedArray[overLappedArrayIndex++] = array[i];
                }
            }
            //Console.WriteLine("Elements in over-lapped Array: ");
            PrintArray(overLappedArray);
        }
    }
}