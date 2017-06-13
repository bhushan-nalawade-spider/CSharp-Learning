using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/* 
 * EX-09: separate odd and even integers -program
 *  
 **************************************************************************  
 */

namespace PracticeExcercises
{
    class Ex9_SeparateEvenOddNumbersOfArrayElements
    {
        internal void findEvenOddNumberOfArrayElements(int[] IntArray)
        {
               Console.WriteLine("-------------------------------------------------------------------------------"); 
               Console.Write("Even numbers: ");
            foreach (int EachElment in IntArray)
                if (EachElment % 2 == 0)
                    Console.Write(EachElment+ " ");
               Console.Write("Odd numbers: ");
            foreach (int EachElment in IntArray)
                if (EachElment % 2 != 0)
                    Console.Write(EachElment + " ");
            Console.WriteLine();
        }
    }
}
