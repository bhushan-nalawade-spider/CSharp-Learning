using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Elements you want in the array:-");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            for(int i=0; i<arraySize;i++)
            {
                Console.Write("element -" + i.ToString() + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int duplicateCount = 0;

            for(int i=0;i<arraySize;i++)
            {
                for(int j= (i+1); j<arraySize;j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        duplicateCount = duplicateCount + 1;
                        break;
                    }

                }
            }

            Console.WriteLine("The number of duplicate elements found in the array is:= " + duplicateCount);
            Console.ReadLine();
        }
    }
}
