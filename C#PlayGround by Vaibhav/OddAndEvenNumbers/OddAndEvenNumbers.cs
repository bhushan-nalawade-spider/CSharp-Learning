using System;

namespace OddAndEvenNumbers
{
    internal class OddAndEvenNumbers
    {
        private static void Main(string[] args)
        {
            var inputFromUser = GetInputFromUser();
            IsOdd(inputFromUser);
            IsEven(inputFromUser);
        }

        public static int[] GetInputFromUser()
        {
            int[] inputArray = {};
            try
            {
                Console.Write('\n' + "Enter the size of array => ");
                var sizeOfArray = int.Parse(Console.ReadLine());
                inputArray = new int[sizeOfArray];
                for (var index = 0; index < sizeOfArray; index++)
                {
                    Console.Write("Element {0}  =>", index);
                    inputArray[index] = int.Parse(Console.ReadLine());
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

        public static void IsOdd(int[] inputFromUser)
        {
            Console.WriteLine("Odd numbers are");
            for (var index = 0; index < inputFromUser.Length; index++)
            {
                if (inputFromUser[index]%2 != 0)
                {
                    Console.Write(inputFromUser[index] + " ");
                }
            }
        }

        public static void IsEven(int[] inputFromUser)
        {
            Console.WriteLine('\n' + "Even numbers are ");
            for (var index = 0; index < inputFromUser.Length; index++)
            {
                if (inputFromUser[index]%2 == 0)
                {
                    Console.Write(inputFromUser[index] + " ");
                }
            }
        }
    }
}