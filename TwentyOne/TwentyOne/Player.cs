using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player); // Takes game and adds a player to it
            return game; // returns game
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); // Takes game and removes a player
            return game; 
        }
    }
}
