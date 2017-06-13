using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class RandomBoard
    {
        int i, j = 0;

        public void StorePlayersInArrayRandomly(int [,] arr, int size, int countOfPlayers)
        {
            Random randNum = new Random();

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    arr[i, j] = randNum.Next(1, countOfPlayers + 1);
                }
            }
        }

        public void PrintPlayersStoredInArray(int [,] arr, int size)
        {
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + "   ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
