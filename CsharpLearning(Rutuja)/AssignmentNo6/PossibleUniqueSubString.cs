using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo6
{
    class PossibleUniqueSubString
    {
        public static void PossibleUniqueSub(string input)
        {
            //declare the string variable  
            string final = "";

            //Get a string of possible substrings with out uniqueness  
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

            //Print the array  
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
