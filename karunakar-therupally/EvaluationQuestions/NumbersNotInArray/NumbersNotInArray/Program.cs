using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] orignalArray = new int[ArraySize];
            Console.Write("Enter elments of array: ");
            for (int i=0; i<ArraySize;i++)
                orignalArray[i]= int.Parse(Console.ReadLine());
            Console.Write("Elements in original Array: ");
            PrintArray(orignalArray);

            Console.Write("Enter start and end values reqd array: ");
            int start = int.Parse(Console.ReadLine());
            if(start> orignalArray.Min()) {
                Console.Write($"Enter {start} <= {orignalArray.Min()}.. ");
                start = int.Parse(Console.ReadLine());
                if (start > orignalArray.Min())
                {
                    Console.WriteLine($"{start} is still > {orignalArray.Min()}, exiting");
                    Console.ReadKey();
                    return;
                }
            }

            int end = int.Parse(Console.ReadLine());
            if (end < orignalArray.Max())
            {
                Console.Write($"Enter {end} values >= {orignalArray.Max()} ");
                end = int.Parse(Console.ReadLine());
                if (end < orignalArray.Max())
                {
                    Console.WriteLine($"{end} is still < {orignalArray.Max()}, exiting");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Lowest :{orignalArray.Min()}");
            Console.WriteLine($"Highest :{orignalArray.Max()}");

            ElementsNotInArray(orignalArray, start, end);

            Console.ReadKey();
        }

        private static void PrintArray(int[] array)
        {
           
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");
            Console.Write("]");
        }

        private static void ElementsNotInArray(int[] array, int start, int end)
        {
            //int unlistedElementArraySize = 0;
            //if (end==array.Max()) 
            //    unlistedElementArraySize = end - start - array.Length + 2;
            //else if(end > array.Max())
                int unlistedElementArraySize = end - start - array.Length + 1;

            if (unlistedElementArraySize==0) {
                Console.WriteLine($"no elements between {start} and {end} to print, exiting...");
                return;
            }

            int[] UnlistedElementArray = new int[unlistedElementArraySize]; // - array.Min];
            int j = 0;

            for (int i = start ; i <= end; i++)
            {
                if (!array.Contains(i))
                    UnlistedElementArray[j++] = i;
            }
            Console.Write("Elements not in original Array: ");
            PrintArray(UnlistedElementArray);
            }
    }
}
