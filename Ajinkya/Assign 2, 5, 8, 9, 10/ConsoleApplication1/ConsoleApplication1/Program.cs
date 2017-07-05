using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadExcel 
{
    class Program
    {
        static void Main(string[] args)
        {
           // Read_Excel abc = new Read_Excel();
            OddEven OE = new OddEven();
            OE.Read_From_Excel();
            
            OE.PrimeNumber();
            OE.binary_triangle();
            OE.Store_odd_even();
            OE.print_oddEven_numbers();
            OE.duplicate();
            Console.ReadLine();
            
        }
    } 
    class Read_Excel
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = null; //xlApp.Workbooks.Open(@"d:\prime");
        Excel._Worksheet xlWorksheet = null; //xlWorkbook.Sheets[1];
        Excel.Range xlRange = null; //xlWorksheet.UsedRange;
        public double[] ExcelNumbers;
       
        public void Read_From_Excel()
        {
            Console.WriteLine("Base Class \n");
           xlWorkbook = xlApp.Workbooks.Open(@"d:\prime");
           xlWorksheet = xlWorkbook.Sheets[1];
          // xlRange = (Excel.Range)xlWorksheet.get_Range(xlWorksheet.Cells[1, 1],xlWorksheet.Cells[1,14]);
           xlRange = xlWorksheet.UsedRange;
           int rows = xlRange.Rows.Count;
           int col = xlRange.Columns.Count;
           ExcelNumbers = new double[col];
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col -1 ; j++)
                {
                  //  ExcelNumbers[j] = (xlRange.Cells[i, j] as Excel.Range).Value2;
                   // Console.WriteLine(ExcelNumbers[j]);
                    double x = ((xlRange.Cells[i, j] as Excel.Range).Value2);
                  ExcelNumbers[j] = x;
                }
            }
        }
       public void PrimeNumber()
        {
            for (int j = 1 ; j <= (ExcelNumbers.Length - 1) ; j++)
            {
                if(ExcelNumbers[j] == 1)
                    Console.WriteLine(ExcelNumbers[j] + " is prime");
                else
                {
                    for (int i = 2; i <= ExcelNumbers[j] - 1; i++)
                    {
                        if (ExcelNumbers[j] % i == 0)
                            continue;
                            
                    }
                    Console.WriteLine(ExcelNumbers[j] + " is prime");
                }
            }
            
        }
       public void binary_triangle()
       {
           int limit = 15, triangle = 0;
           for (int i = 0; i <= triangle; i++)
           {
               for (int j = 0; j <= limit; j++)
               {
                      if (j % 2 == 0)
                           Console.Write("0");                  // if even number print zero(0)
                       else
                           Console.Write("1");                  // if odd number, print one (1)

                       if (j == triangle)                       // To check the columm size for each row
                           break;                  
               }
               Console.WriteLine("");
               triangle++;
               if (i == limit)
                   break;
           }
           
       }
       
    }
    
}
