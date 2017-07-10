using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLearning_Purpose
{
    class Program
    {
        static void Main(string[] args)
        {
            AddData();
        }

        public static void AddData()
        {
            int row, col, rowIndex, colIndex;
            Console.Write("Enter Number Of Rows Of MatriX ");
            row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Rows Of MatriX ");
            col = Int32.Parse(Console.ReadLine());
        
            Console.Write("Enter Number Of Players ");
            int noOfPlayers = Int32.Parse(Console.ReadLine());
            int [,]matrixFromUser = new int[,] {};
            var random = new Random();
            for (rowIndex = 0; rowIndex < row; rowIndex++)
            {
                Console.WriteLine('\n');
                for (colIndex = 0; colIndex < col; colIndex++)
                {
                    matrixFromUser[rowIndex, colIndex] = random.Next(1, noOfPlayers);
                    Console.Write(matrixFromUser[rowIndex, colIndex]);
                    Console.Write('\t');

                }
            }
        }

        public static Employee EmpDetails()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter name");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter City");
            employee.EmployeeCity = Console.ReadLine();
            Console.WriteLine("Enter designation");
            employee.EmployeeDesignation = Console.ReadLine();
            Console.WriteLine("Enter salary");
            employee.EmployeeSalary = Int32.Parse(Console.ReadLine());
            return employee;
        }
    }
}
