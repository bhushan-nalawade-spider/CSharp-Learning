using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Pr7_Deletefile
{
    class Pr7_Deletefile
    {
        static void Main(string[] args)
        {
            String fileDirectory = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            String fileName = "\\Test.txt";
            String requiredPath = fileDirectory + fileName;

           createFile(requiredPath);
            deleteFile(requiredPath);

            Console.Read();
        }

        private static void createFile(string requiredPath)
        {
            FileStream F = new FileStream(requiredPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("The file is created at: " + requiredPath);
        }

        private static void deleteFile(string requiredPath)
        {
            if (File.Exists(requiredPath))
            {
                File.Delete(requiredPath);
                Console.WriteLine("File Deleted at " + requiredPath);
            }
            else
                Console.WriteLine("The file does not exist at: " + requiredPath);
        }
    }
}
