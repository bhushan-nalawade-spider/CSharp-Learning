using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheScore
{
    class AddDataToMatrix
    {
        

        public static Matrix CreateMatrix()
        {
            Matrix matrix = new Matrix();
            try
            {
                int row, col, rowIndex, colIndex;
                Console.Write("Enter Number Of Rows Of MatriX ");
                row = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Number Of Rows Of MatriX ");
                col = Int32.Parse(Console.ReadLine());
                int[,] matrixFromUser = new int[row, col];
                matrix.noOfColOnBoard = col;
                matrix.noOfRowOnBoard = row;
                matrix.matrix = matrixFromUser;
                

                Console.Write("Enter Number Of Players ");
                int noOfPlayers = Int32.Parse(Console.ReadLine());
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
            catch (Exception ex)
            {

                if (ex != null)
                    Console.WriteLine("Invalid coordinates, Program terminated...");
                Environment.Exit(0);
            }

            return matrix;
        }

        
    }


}
