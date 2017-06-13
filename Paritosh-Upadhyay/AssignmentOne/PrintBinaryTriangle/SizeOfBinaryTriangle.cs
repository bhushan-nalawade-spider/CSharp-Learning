using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBinaryTriangle
{
    class SizeOfBinaryTriangle
    {
        public int NumberOfRowsForBinaryTriangle()
        {
            Console.WriteLine("Enter the number of rows for binary triangle: ");
            int NumberOfRows = int.Parse(Console.ReadLine());
            return NumberOfRows;
        }
    }
}
