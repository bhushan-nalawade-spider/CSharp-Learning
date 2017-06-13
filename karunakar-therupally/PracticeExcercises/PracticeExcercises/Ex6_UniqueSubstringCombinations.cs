using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/*  
 *  EX-06: List all possible unique substrings in a given String - program
 *  
 **************************************************************************
 */

namespace PracticeExcercises
{
    class Ex6_UniqueSubstringCombinations
    {

        public void FindUniqueSubstringCombinations()
        {
            Console.Write("Eneter the input String:");

            //Declare a string variable, to accept user input
            string input = Console.ReadLine();

            //declare the string variable to store all substrings  
            string final = "";

            //Loop thru differnt combinations of sub-string.. Get a string of possible substrings with out uniqueness  
            for (int i = 0; i < input.Length; i++)
            {
                string str = "";
                for (int j = i; j < input.Length; j++)
                {
                    str += input[j];
                    final += str + ",";
                }
            }

            //Remove the ending comma from the string  
            final = final.Remove(final.Length - 1, 1);

            //Get an array after Spilt the string on basis of comma  
            string[] arr = final.Split(',');

            //Get the distinct array  
            arr = arr.Distinct().ToArray();
            Console.WriteLine("-------------------------------------------------------------------------------");
            //Print the array  
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            //Console.ReadKey();

        }
    }
}
