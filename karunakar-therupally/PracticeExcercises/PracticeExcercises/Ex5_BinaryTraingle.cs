using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/*  
 *  EX-05: Print a Binary Triangle - program
 *  
 **************************************************************************
 */
namespace PracticeExcercises
{
    class Ex5_BinaryTraingle
    {

        public void PrintBinaryTriangle(int binaryTriangleLevel)
        {

            //Declare a variable and assign 0 (zero) to it, which has to store modulus of 2
            int binary = 0;
            Console.WriteLine("-------------------------------------------------------------------------------");
            //Loop thru level each binary level
            for (int i = 0; i <= binaryTriangleLevel; i++)
            {
                //Loop thru each binary to get o/p for specific level
                for (int j = 0; j <= i; j++)
                {
                    //store modulus into binary
                    binary = j % 2;
                    Console.Write("{0}", binary);

                }
                Console.WriteLine();
            }
            //Console.ReadKey();
            
        }

    }
}
