using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMissingNumbers
{
    public class ReadIntegers
    {
        public static int[] arrayOfNumbers = new int[50];
        public static int count = 0;
        public static int startRange = 0;
        public static int endRange = 0;

        public void InputSizeOfArray()
        {
            Console.WriteLine("Enter the size of array: ");
            count = int.Parse(Console.ReadLine());
        }

        public void InputNumberToArray()
        {
            for (int temp = 0; temp < count; temp++)
            {
                Console.Write("Enter number {0}: ", temp + 1);
                arrayOfNumbers[temp] = int.Parse(Console.ReadLine());
            }
        }

        public void InputStartRange()
        {
            Console.WriteLine("Enter the start range: ");
            startRange = int.Parse(Console.ReadLine());
        }

        public void InputEndRange()
        {
            Console.WriteLine("Enter the end range: ");
            endRange = int.Parse(Console.ReadLine());
        }
    }
}
