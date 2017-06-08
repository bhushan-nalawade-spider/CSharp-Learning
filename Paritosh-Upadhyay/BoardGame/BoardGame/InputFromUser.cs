using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class InputFromUser
    {
        public int InputSizeOfBoard()
        {
            Console.Write("Enter the size of board: ");
            int size = int.Parse(Console.ReadLine());
            return size;
        }

        public int InputNumberOfPlayers()
        {
            Console.Write("Enter the number of players: ");
            int countOfPlayers = int.Parse(Console.ReadLine());
            return countOfPlayers;
        }

        public int CoordinatesOfBoard(int size, string axis)
        {
            Console.Write("Enter the {0} coordinate between 0 and {1}: ",axis,size-1);
            int temp = int.Parse(Console.ReadLine());
            if (temp > size-1 || temp < 0)
            {
                Console.WriteLine("{0} coordinate can not be less than 0 or greater than the size of board. Exiting the program...",axis);
                Environment.Exit(0);
            }
            return temp;
        }

        public int NumberOfTiers()
        {
            Console.Write("Enter the number of levels: ");
            int numberOfTiers = int.Parse(Console.ReadLine());
            return numberOfTiers;
        }
    }
}
