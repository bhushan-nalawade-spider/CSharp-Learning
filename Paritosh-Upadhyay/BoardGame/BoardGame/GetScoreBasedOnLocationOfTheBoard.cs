using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class GetScoreBasedOnLocationOfTheBoard
    {
        public int RightLocationOnBoard(int [,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser;
            int yCoordinate = yCoordinateEnteredByUser + a;

            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int LeftLocationOnBoard(int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser;
            int yCoordinate = yCoordinateEnteredByUser - a;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int AboveLocationOnBoard(int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser - a;
            int yCoordinate = yCoordinateEnteredByUser;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int BelowLocationOnBoard(int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser + a;
            int yCoordinate = yCoordinateEnteredByUser;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int LeftAboveLocationOnBoard(int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser - a;
            int yCoordinate = yCoordinateEnteredByUser - a;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int RightAboveLocationOnBoard (int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser + a;
            int yCoordinate = yCoordinateEnteredByUser + a;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int LeftBelowLocationOnBoard (int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser + a;
            int yCoordinate = yCoordinateEnteredByUser - a;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }

        public int RightBelowLocationOnBoard(int[,] arr, int a, int occ, int size, int xCoordinateEnteredByUser, int yCoordinateEnteredByUser)
        {
            int xCoordinate = xCoordinateEnteredByUser - a;
            int yCoordinate = yCoordinateEnteredByUser + a;
            if (xCoordinate >= 0 && xCoordinate <= size && yCoordinate >= 0 && yCoordinate <= size)
            {
                if (arr[xCoordinateEnteredByUser, yCoordinateEnteredByUser] == arr[xCoordinate, yCoordinate])
                {
                    occ++;
                }
            }
            return occ;
        }
    }
}
