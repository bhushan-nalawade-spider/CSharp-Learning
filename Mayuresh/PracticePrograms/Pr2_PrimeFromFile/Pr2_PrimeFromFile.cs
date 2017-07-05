using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Pr2_PrimeFromFile
{
    class Pr2_PrimeFromFile
    {
        
        static void Main(string[] args)
        {
            //Create file path for the file 

            String fileDirectory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            String requiredCSVpath = fileDirectory + "\\test.csv";
            String requiredExcelPath = fileDirectory + "\\excelTest.xlsx";

            //createExcel(requiredExcelPath);
            //readExcel(requiredExcelPath);
            primeOrNot(requiredExcelPath);
            
            Console.Read();

        }

        private static void primeOrNot (String filePath)
        {
            //Console.WriteLine(filePath);

            //FileStream F = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            if (filePath.EndsWith(".csv"))
                checkCSVfile(filePath);
            else if (filePath.EndsWith(".xls") || filePath.EndsWith(".xlsx"))
                checkXLfile(filePath);
        }

        private static void checkCSVfile(String filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            int number;
            try
            {
                while ((number = Int32.Parse(sr.ReadLine())) != null)
                {
                    Console.WriteLine(number);

                    if (number < 2)
                        Console.WriteLine("The number " + number + " is an exception to the prime numbers.");
                    else
                    {
                        if (isPrime(number))
                            Console.WriteLine("The number " + number + " is Prime");
                        else
                            Console.WriteLine("The number " + number + " is not Prime");
                    }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static void checkXLfile(String filePath)
        {
            int[,] excelData = readExcel(filePath);
            for (int i = 0; i < excelData.GetLength(0); i++)
            {
                //Console.WriteLine("length of first dim. " + excelData.Length);
                //Console.WriteLine("length of second dim. " + excelData.GetLength(1));
                for (int j = 0; j < excelData.GetLength(1); j++)
                {
                    if (excelData[i,j] < 2)
                        Console.WriteLine("The number " + excelData[i,j] + " is an exception to the prime numbers.");
                    else
                    {
                        if (isPrime(excelData[i,j]))
                            Console.WriteLine("The number " + excelData[i,j] + " is Prime");
                        else
                            Console.WriteLine("The number " + excelData[i,j] + " is not Prime");
                    }
                }
                Console.WriteLine(i + "st row finished");
            }
        }

        private static bool isPrime(int num)
        {
            
            for (int i = 2; i <= num/2; i++)
            {
                if (num%i == 0)
                    return false;
            }
            return true;
        }

        private static void createExcel(String filePath)
        {
            Application xlApp = new Application();
            if (xlApp == null)
                Console.WriteLine("Excel is not properly installed");

            xlApp.Visible = true;

            Workbook xlWorkBook = xlApp.Workbooks.Add(Type.Missing);
            Worksheet xlWorkSheet = (Worksheet)xlWorkBook.ActiveSheet;
            xlWorkSheet.Name = "FirstWorkSheet";

            for (int i = 1; i <= 10; i++ )
            {
                xlWorkSheet.Cells[i, 1] = i;
            }

            xlWorkBook.SaveAs(filePath);

            xlWorkBook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            //return "";
        }

       private static int [,] readExcel(String filePath)
        {
           Application xlApp = new Application();
           if (xlApp == null)
                Console.WriteLine("Excel is not properly installed");

           xlApp.Visible = true;
           Workbook xlWorkBook = xlApp.Workbooks.Open(filePath);

           Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

           Range sheetRange = xlWorkSheet.UsedRange;
           int rowCount = sheetRange.Rows.Count;
           int colCount = sheetRange.Columns.Count;
           int[,] dataEntries = new int[rowCount, colCount];

           for (int rCnt = 1; rCnt <= rowCount; rCnt++)
           {
               for (int cCnt = 1; cCnt <= colCount; cCnt++)
               {
                   if ((sheetRange.Cells[rCnt, cCnt]).Value2 == null)
                       dataEntries[rCnt - 1, cCnt - 1] = -1;
                   else
                       dataEntries[rCnt - 1, cCnt - 1] = (int)((sheetRange.Cells[rCnt, cCnt]).Value2);
               }
           }

           for (int rCnt = 1; rCnt <= rowCount; rCnt++)
           {
               for (int cCnt = 1; cCnt <= colCount; cCnt++)
               {
                   if ((sheetRange.Cells[rCnt, cCnt]).Value2 == null)
                       Console.WriteLine(-1);
                   else
                       Console.WriteLine((sheetRange.Cells[rCnt, cCnt]).Value2);
               }
           }

           //Console.WriteLine((sheetRange.Cells[1, 1]).Value2);

           xlWorkBook.Close();
           xlApp.Quit();

           Marshal.ReleaseComObject(xlWorkSheet);
           Marshal.ReleaseComObject(xlWorkBook);
           Marshal.ReleaseComObject(xlApp);

           return dataEntries;
        }

       
    }
}
