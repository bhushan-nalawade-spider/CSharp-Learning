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
            BinaryTriangle();
        }

        public static void BinaryTriangle()
        {
            Console.WriteLine("Enter the number for the traingle to be printed:");
            string str = Console.ReadLine();

            int maxTriangleLimit = Convert.ToInt32(str);

            for (int i = 0; i < maxTriangleLimit; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j % 2);
                }
                Console.WriteLine(" ");
            }

            Console.Read();
        }

    }
}
