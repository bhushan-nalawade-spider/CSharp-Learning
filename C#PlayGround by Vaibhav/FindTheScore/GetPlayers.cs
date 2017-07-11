using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheScore
{
    class GetPlayers
    {

        public static Coordinates GetCoordinatesFromUser()
        {
            Coordinates coordinates = new Coordinates();
            try
            {
                Console.Write("Enter noOfRowOnBoard for which you want to calculate the score ");
                int rowCoordToCalScore = Int32.Parse(Console.ReadLine());

                Console.Write("Enter column for which you want to calculate the score ");
                int colCoordTCalScore = Int32.Parse(Console.ReadLine());

                coordinates.rowPositionToCalScore = rowCoordToCalScore;
                coordinates.colPositionToCalScore = colCoordTCalScore;

            }
            catch (Exception ex)
            {
                if(ex != null)
                    Console.WriteLine("Invalid coordinates, Program terminated...");
                System.Environment.Exit(0);
            }

            return coordinates;
        }
    }
}
