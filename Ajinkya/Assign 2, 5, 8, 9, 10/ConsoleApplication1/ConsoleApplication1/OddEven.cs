using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadExcel
{
    class OddEven : Read_Excel
    {
        List<double> even = new List<double>();
        List<double> odd = new List<double>();

        public void Store_odd_even()
        {
            Console.WriteLine("Derivied Class \n");
            for (int j = 0; j < ExcelNumbers.Length; j++)
            {
                if (ExcelNumbers[j] % 2 == 0)                // if even number
                {
                    even.Add(ExcelNumbers[j]);
                }
                else                                         // if odd number
                {
                    odd.Add(ExcelNumbers[j]);
                }

            }
        }
        public void print_oddEven_numbers()
        {
            Console.WriteLine("Even numbers : ");
            for (int i = 0; i < even.Count; i++)
                Console.Write(even[i] + " ,");

            Console.WriteLine("\n Odd numbers : ");
            for (int i = 0; i < odd.Count; i++)
                Console.Write(odd[i] + ", ");
        }
        public void duplicate()
        {
            int TotalDuplicates = 0;
            Console.WriteLine("\n Duplicate Numbers are : ");
            for (int i = 0; i < ExcelNumbers.Length; i++)
            {
                for (int j = 0; j < ExcelNumbers.Length; j++)
                {
                    if (i != j)
                    {
                        if (ExcelNumbers[i] == ExcelNumbers[j])
                        {
                            Console.WriteLine(ExcelNumbers[i] + " ");
                            TotalDuplicates++;
                        }
                    }
                }
            }
            Console.WriteLine("\n TOtal Duplicate are : " + TotalDuplicates / 2);
        }
    }
}