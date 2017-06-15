using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartEndArray
{
    class StartEndArray
  
    {
        static void Main(string[] args)
        {
         
            int[] numbers = { 3, 9, 17 };
            Console.WriteLine("Enter the start number");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end number");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if (!numbers.Any(x => x == i))
                {
                    Console.WriteLine(i);
                }
            }
                Console.ReadLine();
            
        }
    }
}
