using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheScore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Matrix matrix=AddDataToMatrix.CreateMatrix();
            Coordinates coordinates=GetPlayers.GetCoordinatesFromUser();
            int totalScore= CalculateScore.getScore(matrix,coordinates);
            Console.WriteLine("Score of " + matrix.matrix[coordinates.rowPositionToCalScore,coordinates.colPositionToCalScore] + " is =>" + totalScore );
        }
    }
}
