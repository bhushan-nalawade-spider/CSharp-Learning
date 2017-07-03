using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_BinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Pr5_BinaryTriangle();
        }

        public static void Pr5_BinaryTriangle()
        {
            Console.WriteLine("Enter the number for which the triangle is to be printed:");
            string str = Console.ReadLine();

            int maxTriangleLimit = Convert.ToInt32(str);

            for (int i = 0; i < maxTriangleLimit; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j % 2);
                }
                Console.WriteLine("");
            }

            Console.Read();
        }

    }
}
