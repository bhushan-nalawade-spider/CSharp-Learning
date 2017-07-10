using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindTheDuplicate
{
    class FindTheDuplicate
    {
        static void Main(string[] args)
        {
            int[] inputFromUser = GetInputFromUser();
            IsDuplicate(inputFromUser);
        }

        public static int[] GetInputFromUser()
        {

            int[] inputArray = new int[] { };
            try
            {
                Console.Write('\n' + "Enter the size of array => ");
                int sizeOfArray = Int32.Parse(Console.ReadLine());
                inputArray = new int[sizeOfArray];
                for (int index = 0; index < sizeOfArray; index++)
                {
                    Console.Write("Element {0}  =>", index);
                    inputArray[index] = Int32.Parse(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                    Console.WriteLine("invalid input,program terminated");
                Environment.Exit(0);
            }

            return inputArray;
        }

        public static void IsDuplicate(int[] inputFromUser)
        {
            int count = 0;
            for (int counter = 0; counter < inputFromUser.Length; counter++)
            {
                 count = 0;

                for (int index=counter+1; index < inputFromUser.Length; index++)
                {
                    if (inputFromUser[counter] == 0)
                        break;
                    if (inputFromUser[counter] == inputFromUser[index])
                    {
                        count++;
                        inputFromUser[index] = 0;

                    }
                }

                if (count > 0)
                {
                    Console.WriteLine(inputFromUser[counter]+ " is a duplicate number and it occured {0} times",count+1);
                }
               
            }

            if (count == 0)
            {
                Console.WriteLine("No duplicate found!");
            }

            
        }
    }
}
