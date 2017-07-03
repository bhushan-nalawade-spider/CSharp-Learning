using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            result res = new result();
            res.FindGreater();
            res.FindSmaller();
        }
    }
    class result
    {
         public  int[] a = { 10, 15, 45, 213, 48, 78, 01, 2, 56 };
         public int GreaterNumber = 0, i = 0, SmallNumber;

       public void FindGreater()
        {
            while (i < a.Length)
            {
                if (a[i] > GreaterNumber)
                    GreaterNumber = a[i];
                i++;
            }
            Console.WriteLine(GreaterNumber);
            Console.ReadLine();
        }
        
       public void FindSmaller()
        {
            i = 0;
            SmallNumber = GreaterNumber;
            while (i < a.Length)
            {
                if (a[i] < SmallNumber)
                    SmallNumber = a[i];
                i++;
            }
            Console.WriteLine(SmallNumber);
            Console.ReadLine();
        }
    }
}
