using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOfTenNo = new int[4];

            ArrayOfTenNo[0] = 1;
            ArrayOfTenNo[1] = 2;
            ArrayOfTenNo[2] = 3;
            ArrayOfTenNo[3] = 4;

           if (ArrayOfTenNo[0] > ArrayOfTenNo[1])
                Console.WriteLine("largest" + ArrayOfTenNo[0]);
           else
               Console.WriteLine("smallest" + ArrayOfTenNo[1]);

           if(ArrayOfTenNo[0] > ArrayOfTenNo[2])
            Console.WriteLine("largest" + ArrayOfTenNo[0]);
            else
             Console.WriteLine("smallest" + ArrayOfTenNo[2]);

            if (ArrayOfTenNo[0] > ArrayOfTenNo[3])
                Console.WriteLine("largest" + ArrayOfTenNo[0]);
            else
                Console.WriteLine("smallest" + ArrayOfTenNo[3]);
        }
    }
}
