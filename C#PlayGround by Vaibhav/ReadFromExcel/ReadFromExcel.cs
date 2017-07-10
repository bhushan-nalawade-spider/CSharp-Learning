using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace ReadFromExcel
{
    class ReadFromExcel
    {
        static void Main(string[] args)
        {
            ReadDataFromExcel();
        }

        public static void ReadDataFromExcel()
        {
            Excel.Application xlApp = new Excel.Application();
//            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"TestData\ExcelSheetData.xlsx");
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\C# PlayGround\ReadFromExcel\TestData\ExcelSheetData.xlsx");

            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            var last= xlRange.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
//            Console.WriteLine(xlRange.Row);  
//            Console.WriteLine (xlRange.Column);
//            Console.WriteLine(last.Row);
//            Console.WriteLine(last.Column);
            for (int i = 1; i <= last.Row; i++)
            {
                var cell = (Excel.Range) xlWorksheet.Cells[i,1];
                var val = Int32.Parse(cell.Value.ToString());
                isPrime(val);

            }
        }

        public static void isPrime(int number)
        {
            int counter = 0;
            for (int i = 2; i < number; i++)
            {
                if (number%i == 0)
                    counter ++;
            }
            
            if(number==1 ||number==2 ||counter==0)
                Console.WriteLine("{0} is a prime number",number);
        }
    }
}
