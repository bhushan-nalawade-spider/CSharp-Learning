using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Pr1_LargestSmallest
    {
        public static void Main(string[] args)
        {
            const int arraySize = 10;

            /*int[] numberArray = {5, 46, 986456, 56, 897,
                                    5351, 43, 987, 77554, 2 };   */

            int[] numberArray = new int[arraySize];

            for (int number=0; number < arraySize; number++ )
            {
                Console.WriteLine("Enter number " +(number+1) +" :");
                string str = Console.ReadLine();

                try
                {
                    int enteredNum = Convert.ToInt32(str);
                    numberArray[number] = enteredNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }

/*                while (enteredNum == 0)
                {
                    Console.WriteLine(" The number " + enteredNum + " is not allowed. Enter again:");

                    str = Console.ReadLine();
                    enteredNum = Convert.ToInt32(str);
                }   */

            }

            int largestInt = numberArray [0];
            int smallestInt =numberArray [0];
            foreach (int number in numberArray)
            {
                if (largestInt < number)
                    largestInt= number;
                if (smallestInt > number)
                    smallestInt = number;
            }

            Console.WriteLine ("Largest number is: " + largestInt);
            Console.WriteLine ("Smallest number is: " + smallestInt);

            Console.Read();

        }
    }
}
