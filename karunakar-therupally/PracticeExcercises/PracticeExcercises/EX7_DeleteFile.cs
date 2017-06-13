using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************************************************/
/*  
 *  EX-07: Delete a file from the particular location-program
 *  
 **************************************************************************
 */

namespace PracticeExcercises
{
    class EX7_DeleteFile
    {
        public void DeleteFileFrom(string dir)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            if (!Directory.Exists(dir))
            {
                Console.WriteLine("{0} does not exists, create {0} folder and place a file to delete from it, exiting...", dir);
                return;
            }

            string fileName;
            Console.Write("Enter name of file to delete from {0} (including extension): ",dir);
            fileName = dir +"\\" +Console.ReadLine();
            string[] filePaths = Directory.GetFiles(dir);
            Console.WriteLine("-------------------------------------------------------------------------------");
            bool flag = false;
            foreach (string filePath in filePaths)
                if (filePath.Equals(fileName, StringComparison.InvariantCultureIgnoreCase))
                {
                    File.Delete(filePath);
                    Console.WriteLine("Found: " + filePath + " deleting...");
                    flag = true;
                }
            if (flag == false) { Console.WriteLine("{0}, File not found, can not delete...",fileName); }
            Console.WriteLine("List of files in {0}", dir);
            Console.WriteLine("-------------------------------------------------------------------------------");
            filePaths = Directory.GetFiles(dir);
            foreach (string filePath in filePaths)
            {
                Console.WriteLine(filePath);
            }
            //Console.ReadKey();

        }
    }
}
