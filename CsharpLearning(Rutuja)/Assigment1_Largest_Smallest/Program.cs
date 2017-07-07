using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Assigment1_Largest_Smallest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[no];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < no; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = arr[0];
            int Largest = arr[0];
            for (int i = 0; i < no; i++)
            {
                if (smallest > arr[i])
                {
                    smallest = arr[i];
                }
            }
            for (int i = 0; i < no; i++)
            {
                if (Largest < arr[i])
                {
                    Largest = arr[i];
                }
            }
            Console.WriteLine("The greater No in the array:" + Largest);
            Console.WriteLine("The smallest No in the array:" + smallest);
            Console.ReadLine();

        }
    }
}
