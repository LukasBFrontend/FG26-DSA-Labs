using System;
using System.Collections.Generic;

namespace DSA.Lab00
{
    public sealed class PlayerCollection
    {
        private readonly List<Player> _players;

        public PlayerCollection(IEnumerable<Player> players)
        {
            if (players == null)
            {
                throw new ArgumentNullException(nameof(players));
            }

            _players = new List<Player>(players);
        }

        public Player? FindById(int id)
        {
            foreach (Player player in _players)
            {
                if (player.Id == id)
                {
                    return player;
                }
            }

            return null;
        }

        public Player? FindHighestScore()
        {
            if (_players.Count == 0)
            {
                return null;
            }

            Player highestScoring = _players[0];

            foreach(var player in _players)
            {
                if (!(player.Score > highestScoring.Score))
                {
                    continue;
                }

                highestScoring = player;
            }
            
            return highestScoring;
        }

        public bool ContainsName(string name)
        {
            foreach(var player in _players)
            {
                if (player.Name != name)
                {
                    continue;
                }

                return true;
            }
            return false;
        }
    }
}
