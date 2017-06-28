using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityLargestAndSmallest(); //this method will define the largest and smallest numbers 

            ChildClass child = new ChildClass(); //--this is to call the inheritence with constructor
            child.print();

           SubStrings.PossibleUniqueSubString();

            Console.ReadKey();



        }



        static void IdentityLargestAndSmallest()
        {
            int[] numbers = { 20, 30, 54, 11, 30, 2, 3 };
            int smallest = numbers[0];
            int largetst = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largetst)
                    largetst = numbers[i];
                else if (numbers[i] < smallest)
                    smallest = numbers[i];

            }

            Console.WriteLine("Largest Number is : " + largetst);
            Console.WriteLine("Smallest Number is : " + smallest);
            
        }
    }


}
  