using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheScore
{
    class CalculateScore
    {
        public static int getScore(Matrix matrix, Coordinates coordinates)
        {
            int valid = validCoordinates(matrix, coordinates);
            int score=0;
            if (valid == 1)
            {
                if ((coordinates.rowPositionToCalScore + 1) < (matrix.noOfRowOnBoard))
                {
                    if ((matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore] ==
                         matrix.matrix[coordinates.rowPositionToCalScore + 1, coordinates.colPositionToCalScore]))
                    {
                        score++;
                    }
                }

                if ((coordinates.rowPositionToCalScore - 1) <= 0)
                {

                    if ((matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore] ==
                         matrix.matrix[coordinates.rowPositionToCalScore - 1, coordinates.colPositionToCalScore]))

                    {
                        score++;
                    }
                }

                if ((coordinates.colPositionToCalScore + 1) < matrix.noOfColOnBoard)
                {


                    if ((matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore] ==
                         matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore + 1]))
                    {
                        score++;
                    }
                }
                if ((coordinates.colPositionToCalScore - 1) >= 0)
                {

                    if ((matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore] ==
                         matrix.matrix[coordinates.rowPositionToCalScore, coordinates.colPositionToCalScore - 1]))

                    {
                        score++;
                    }
                }

            }
            return score;
        }

        public static int validCoordinates(Matrix matrix, Coordinates coordinates)
        {
            int valid = 0;
            if ((matrix.noOfRowOnBoard > coordinates.rowPositionToCalScore) && (matrix.noOfColOnBoard > coordinates.colPositionToCalScore) &&
                coordinates.rowPositionToCalScore >= 0 && coordinates.colPositionToCalScore >= 0)
            {

                valid = valid + 1;
            }
            else
            {
                Console.WriteLine("Invalid coordinates entered. Program Terminated!!");
                Environment.Exit(0);
            }
           
            return valid;
        }
        
    }
}
