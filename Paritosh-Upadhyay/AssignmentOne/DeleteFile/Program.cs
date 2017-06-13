using ConsoleApplication1;
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
            ProgramIntroduction intro = new ProgramIntroduction();
            intro.Introduction("This is a program to delete a file from a directory.");
            
            string file = @"D:\delete\delete.txt";
            if (Directory.Exists(Path.GetDirectoryName(file)))
            {
                if (File.Exists(@"D:\delete\delete.txt"))
                {
                    File.Delete(@"D:\delete\delete.txt");
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exists.");
                }
            }
            else
            {
                Console.WriteLine("No such directory exists.");
            }
        }
    }
}
