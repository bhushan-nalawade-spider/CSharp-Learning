using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the location of the file to be deleted:-");
                String path = Console.ReadLine();

                while (!File.Exists(path))
                {
                    Console.WriteLine("OOPS!! The file does not exist. Please enter a valid path");
                    path = Console.ReadLine();
                }

                File.Delete(path);
                Console.WriteLine("File Deleted successfully");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some error occurred. Please re-run the program");
            }
        }
    }
}
