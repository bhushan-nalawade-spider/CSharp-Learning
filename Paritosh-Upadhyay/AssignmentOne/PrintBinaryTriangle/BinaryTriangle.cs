using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBinaryTriangle
{
    class BinaryTriangle : SizeOfBinaryTriangle
    {
        public void PrintBinaryTriangleOnConsole(int NumberOfRows)
        {
            Console.WriteLine("Binary triangle of {0} rows: ", NumberOfRows);
            Console.Write("\n");

            int temp = 0;

            for (int row = 1; row <= NumberOfRows; row++)
            {
                for (int size = 1; size <= row; size++)
                {
                    if (temp == 0)
                    {
                        Console.Write(0);
                        temp = 1;
                    }
                    else if (temp == 1)
                    {
                        Console.Write(1);
                        temp = 0;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
