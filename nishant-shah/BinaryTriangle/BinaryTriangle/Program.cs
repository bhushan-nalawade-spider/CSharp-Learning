using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows for the pattern:-");
            int rowNum = int.Parse(Console.ReadLine());

            for(int i=1;i<=rowNum;i++)
            {
                
                for(int j=1;j<=i;j++)
                {
                    if (j % 2 == 1)
                        Console.Write("0");
                    else
                        Console.Write("1");

                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
