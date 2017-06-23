using System;
using System.Linq;
namespace OverlappingNum
{
    class OverlappingNum
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] intersect = arr1.Intersect(arr2).ToArray();
            for (int l = 0; l < intersect.Length; l++)
            Console.WriteLine(intersect[l]);
            Console.ReadLine();
        }
    }
}