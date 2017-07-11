using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              throw new CustomException();
            }
            catch (CustomException e)
            {
                Console.WriteLine("Custom exception caught");
            }
            finally
            {
                Console.WriteLine("Cleaning..");
            }
            Console.WriteLine("hi");
            Console.ReadKey();
        }
    }

    class CustomException:ArithmeticException
    {
     
    }
}
