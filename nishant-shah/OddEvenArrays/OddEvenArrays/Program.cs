using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Elements you want in the array:-");
            int arraySize = int.Parse(Console.ReadLine());
            int[] arr = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("element -" + i.ToString() + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < arraySize; i++)
            {
                if (arr[i] % 2 == 0)
                    even.Add(arr[i]);
                else
                    odd.Add(arr[i]);
            }

            Console.WriteLine("The odd elements in the array are:- ");

            foreach (var num in odd)
            {
                Console.Write(num + ",");
                Console.WriteLine();
            }

            Console.WriteLine("The even elements in the array are:- ");
            foreach (var num in even)
            {
                Console.Write(num + ",");

            }

            Console.ReadLine();
            
        }
    }
}
