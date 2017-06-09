using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class PlayersScore
    {
        public void PlayersNormalScore(int selectedPlayer, int scoreOfPlayer)
        {
            Console.WriteLine("Score of player {0}: {1}", selectedPlayer, scoreOfPlayer);
        }

        public void PlayersExponentialScore(int selectedPlayer, int scoreOfPlayer)
        {
            int exponentialScore = 0;

            for (int temp = 0; temp <= scoreOfPlayer; temp++)
            {
                exponentialScore = exponentialScore + temp;
            }
            Console.WriteLine("Exponential score of player {0}: {1}", selectedPlayer, exponentialScore);
        }
    }
}
