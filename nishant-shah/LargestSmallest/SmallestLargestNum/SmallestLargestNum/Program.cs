using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestLargestNum
{
    class Program
    {
        static int[] arr = new int[10];

        static void Main(string[] args)
        {
            TakeArrayInputFromUser();
            FetchSmallestAndLargestInteger();
        }

        private static void TakeArrayInputFromUser()
        {
            Console.WriteLine("Please enter an array of 10 integers in comma separated form:-");
            Console.Write(Environment.NewLine);

            String userInput = Console.ReadLine();
            arr = Array.ConvertAll(userInput.Split(new char[] { ',' }),int.Parse);
        }

        private static void FetchSmallestAndLargestInteger()
        {
            int smallestNum = 0;
            int largestNum = 0;
            for(int count=0; count<10;count++)
            {
                if(count.Equals(0))
                {

                    smallestNum = arr[count];
                    largestNum = arr[count];
                    continue;
                }
                    
                if(arr[count]<smallestNum)
                {
                    smallestNum = arr[count];
                }
                if(arr[count]>largestNum)
                {
                    largestNum = arr[count];
                }
            }

            Console.WriteLine("The Smallest Number is:- " + smallestNum.ToString());
            Console.WriteLine("The Largest Number is:- " + largestNum.ToString());
            Console.ReadLine();

        }
    }
}
