using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvaluationPapers
{
    class MyException : Exception
    {
        public void MyException1()
        {
            Console.WriteLine("An exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
      
    }

    class TestMyException
    {
        public static void Main(String[] arg)
        {
            int d, divi, res;
            Console.WriteLine("Enter the divident:");
            d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            divi = Int32.Parse(Console.ReadLine());
            try
            {
                if (divi == 0)
                {
                    throw new MyException();


                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }

            res = d / divi;
            Console.WriteLine("Result:{0}", res);
            Console.ReadLine();
        }
    }
}  