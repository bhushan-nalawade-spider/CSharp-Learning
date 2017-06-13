using System;
using System.Collections;
using System.Collections.Generic;
/*************************************************************************/
/*  
 *  EX-08: Count total number of duplicate elements in an array-program
 *  
 **************************************************************************
 */

namespace PracticeExcercises
{
    internal class EX8_DuplicateElementsInAnArray
    {
        internal void FindDuplicates()
        {
            Console.Write("Input number of elements: ");
            ArrayList ary = new ArrayList();
            int arraylistSize = int.Parse(Console.ReadLine());
            //ary.Capacity());
            for (int i=0; i< arraylistSize; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                ary.Add(int.Parse(Console.ReadLine()));
            }

            //Array list to store all the duplicate values
            ArrayList dup = new ArrayList();

            for (int i = 0; i < ary.Count; i++)
            {
                for (int j = i + 1; j < ary.Count; j++)
                {
                    //compare each value with following remaining values
                    if (ary[i].Equals(ary[j]))
                    {
                        //When duplicate value is found, check
                        //whether the value not contained in the dup array list
                        if (!dup.Contains(ary[i]))
                        {
                            //if not contains, then add the value to dup array list
                            dup.Add(ary[i]);
                        }
                    }
                }
            }

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Total number of duplicate elements found in the above array is: "+dup.Count);
            Console.Write("Duplicate element(s) in above array: ");
            
            for (int i = 0; i < dup.Count; i++)
            {
                Console.Write(dup[i] + " ");
                //Console.WriteLine("no of duplicates: " + DuplicateCounter); // DupArray.Count);
            }

            Console.WriteLine("");
        }
        
    }
}