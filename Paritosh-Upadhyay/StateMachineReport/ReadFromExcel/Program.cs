using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace StateMachineReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create COM Objects. Create a COM object for everything that is referenced.
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Paritosh\Documents\Visual Studio 2015\Projects\StateMachineReport\ReadFromExcel\ExcelReport\t4.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            List<DateTime> arr1 = new List<DateTime>();
            List<string> arr2 = new List<string>();

            double diff = 0;
            string cellValue1, cellValue2;
            DateTime dt1 = default(DateTime);
            DateTime dt2 = default(DateTime);
            DateTime dt3 = default(DateTime);
            DateTime dt6 = default(DateTime);
            int n = 0;

            if (xlRange.Cells[1, 1] != null && xlRange.Cells[1, 1].Value2 != null)
            {
                cellValue1 = xlRange.Cells[1, 1].Value2.ToString();

                if (DateTime.TryParseExact(cellValue1, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt1))
                {
                    arr1.Add(dt1);
                    arr2.Add(xlRange.Cells[1, 2].Value2.ToString());
                    dt6 = dt1;
                }
            }


            for (int i = 1; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                {
                    cellValue1 = xlRange.Cells[i, 1].Value2.ToString();

                    if (DateTime.TryParseExact(cellValue1, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt1))
                    {
                    }

                    if (xlRange.Cells[i + 1, 1] != null && xlRange.Cells[i + 1, 1].Value2 != null)
                    {
                        cellValue2 = xlRange.Cells[i + 1, 1].Value2.ToString();

                        if (DateTime.TryParseExact(cellValue2, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt2))
                        {
                            diff = (dt2 - dt1).TotalDays;
                            if (diff > 1)
                            {
                                for (int x = 1; x < diff; x++)
                                {
                                    n++;
                                    dt3 = dt1.AddDays(x);
                                    arr1.Add(dt3);
                                    arr2.Add(xlRange.Cells[i, 2].Value2.ToString());
                                }

                                arr1.Add(dt2);
                                arr2.Add(xlRange.Cells[i + 1, 2].Value2.ToString());
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < arr1.Count; j++)
            {
                Console.Write("Date: " + arr1[j]);
                Console.WriteLine("  State: " + arr2[j]);
            }

            DateTime dt4 = default(DateTime);
            Console.WriteLine("Enter starting date in YYYYMMDD format: ");
            string startDate = Console.ReadLine();
            
            try
            {
                if (DateTime.TryParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt4))
                {
                }

            }
            catch
            {
                Console.WriteLine("Bad Entry");
                Environment.Exit(0);
            }

            DateTime dt5 = default(DateTime);
            Console.WriteLine("Enter ending date in YYYYMMDD format: ");
            string endDate = Console.ReadLine();
            

            try
            {
                if (DateTime.TryParseExact(endDate, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt5))
                {
                }

            }
            catch
            {
                Console.WriteLine("Bad Entry");
                Environment.Exit(0);
            }


            if (dt4 > dt5)
            {
                Console.WriteLine("End Date can not be greater then start date.");
                Environment.Exit(0);
            }

            if (dt4 > dt3 || dt5 < dt6)
            {
                Console.WriteLine("Report not available");
                Environment.Exit(0);
            }


            int start = 0;
            int end = 0;
            for (int j = 0; j < arr1.Count; j++)
            {
               if (arr1[j].Equals(dt4))
                {
                   start = j;
                }

                if (arr1[j].Equals(dt5))
                {
                    end = j;
                }
            }


            Console.Clear();
            if (start == 0)
            {
                Console.WriteLine("Report before {0} is not available.",arr1[0]);
            }

            if (end == 0)
            {
                end = arr1.Count;
            }

            for (int c = start; c < end; c++)
            {
                Console.Write("Date: " + arr1[c]);
                Console.WriteLine("  State: " + arr2[c]);
            }

            end = end - arr1.Count;
            if (end == 0)
            {
                Console.WriteLine("State of machine after {0} is: {1}",arr1[arr1.Count-1],arr2[arr1.Count - 1]);
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
