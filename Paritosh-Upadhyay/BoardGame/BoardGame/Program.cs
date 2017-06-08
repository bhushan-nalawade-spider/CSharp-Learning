using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoardGame
{
    class Program
    {
        public static int[,] arrayOfPlayers = new int[10, 10];

        static void Main(string[] args)
        {
            InputFromUser input = new InputFromUser();

            int size = input.InputSizeOfBoard();

            int countOfPlayers = input.InputNumberOfPlayers();

            RandomBoard storeAndPrint = new RandomBoard();

            storeAndPrint.StorePlayersInArrayRandomly(arrayOfPlayers, size, countOfPlayers);

            storeAndPrint.PrintPlayersStoredInArray(arrayOfPlayers, size);

            int xCoordinateEnteredByUser = input.CoordinatesOfBoard(size, "X");

            int yCoordinateEnteredByUser = input.CoordinatesOfBoard(size, "Y");

            int selectedPlayer = arrayOfPlayers[xCoordinateEnteredByUser, yCoordinateEnteredByUser];

            Console.WriteLine("Selected player at location [{0},{1}] is: {2}", xCoordinateEnteredByUser, yCoordinateEnteredByUser, selectedPlayer);

            int numberOfTiers = input.NumberOfTiers();

            int scoreOfPlayer = 0;

            for (int temp = 1; temp <= numberOfTiers; temp++)
            {
                GetScoreBasedOnLocationOfTheBoard score = new GetScoreBasedOnLocationOfTheBoard();

                scoreOfPlayer = score.RightLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.LeftLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.AboveLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.BelowLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.LeftAboveLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.RightAboveLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.LeftBelowLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);

                scoreOfPlayer = score.RightBelowLocationOnBoard(arrayOfPlayers, temp, scoreOfPlayer, size, xCoordinateEnteredByUser, yCoordinateEnteredByUser);
            }

            PlayersScore print = new PlayersScore();

            print.PlayersNormalScore(selectedPlayer, scoreOfPlayer);

            print.PlayersExponentialScore(selectedPlayer, scoreOfPlayer);
        }
    }
}
