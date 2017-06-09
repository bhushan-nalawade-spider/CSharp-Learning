using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReadFromExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create COM Objects. Create a COM object for everything that is referenced.
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Delete\test3.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //Iterate over the rows and columns and print to the console as it appears in the file
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    if (j == 1)
                    {
                        Console.Write("\r\n");
                    }
                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        //string num = xlRange.Cells[i, j].Value2.ToString();
                        double num = xlRange.Cells[i, j].Value2;

                        double k = 0;
                        for (int count = 1; count <= num; count++)
                        {
                            if (num % count == 0)
                            {
                                k++;
                            }
                        }

                        if (k == 2)
                        {
                            Console.WriteLine("{0} is a Prime Number", xlRange.Cells[i, j].Value2);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not a Prime Number", xlRange.Cells[i, j].Value2);
                        }
                    }

                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
