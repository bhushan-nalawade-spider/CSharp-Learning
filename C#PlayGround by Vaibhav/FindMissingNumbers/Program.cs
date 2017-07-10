using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = DisplayMenu();
            if (option != 1)
                Environment.Exit(0);
            int []userinput = GetUserInput();
           int [] range = GetRange();
            CheckMissingNumbers(range,userinput);
        }

        public static int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("***************Welcome to Find Missing Number program ****************");
            Console.WriteLine("Please enter option");
            Console.WriteLine("1. Find the mising Number");
            Console.WriteLine("2. Exit");
            int option;

            if (!int.TryParse(Console.ReadLine(), out option) || option > 2 || option < 0)
            {
                Console.WriteLine("Invalid input. Find Missing Number Program Terminated");
                Environment.Exit(0); 
            }
         
            return option;
        }

        public static int[] GetUserInput()
        {
                Console.WriteLine("Please enter size of input range");
                int rangeSize = int.Parse(Console.ReadLine());
                int[] inputArray = new int[rangeSize];

                for (int size=0;size<rangeSize;size++)
                {
                    Console.Write("input [{0}] => ", size);
                    inputArray[size] = int.Parse(Console.ReadLine());
                }

                Array.Sort(inputArray);  //sorted the input data
            
            return inputArray;
        }

        public static int[] GetRange()
        {
            int[] arrayRange = new int[] { };
            try
                {
                    Console.Write('\n' + "Range starts from => ");
                    int startingIndex = Int32.Parse(Console.ReadLine());
                    Console.Write("Range ends at => ");
                    int endingIndex = Int32.Parse(Console.ReadLine());
                   
                    int arraySize = endingIndex - startingIndex + 1;
                    arrayRange = new int[arraySize];
                    for (int indexOfRange = 0; indexOfRange < arraySize; indexOfRange++)
                    {
                        arrayRange[indexOfRange] = startingIndex;
                        startingIndex = startingIndex + 1;
                        Console.Write(arrayRange[indexOfRange] + " ");
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null)
                        Console.WriteLine("Please enter valid values..");
                    Environment.Exit(0);
                }
            return arrayRange;
        }

        public static void CheckMissingNumbers(int[] GetRange, int[] UserInput)
        {
           
                string missingNumbers = "";
                for (int indexOfRange = 0; indexOfRange < GetRange.Length; indexOfRange++)
                {
                    for (int indexOfUserinput = 0; indexOfUserinput < UserInput.Length; indexOfUserinput++)
                    {
                        if (UserInput[indexOfUserinput] == GetRange[indexOfRange])
                            break;
                        if ((UserInput[indexOfUserinput] != GetRange[indexOfRange]) &&
                            (indexOfUserinput == UserInput.Length - 1))
                        {
                            missingNumbers = missingNumbers + GetRange[indexOfRange].ToString() + '\n';
                        }
                    }

                }
                if (missingNumbers.Length != 0)
                {
                    Console.WriteLine("missing numbers are " + '\n' + missingNumbers);
                }
                else
                {
                    Console.WriteLine('\n' + " No missing number found ");
                }
            }
       
    }
}
