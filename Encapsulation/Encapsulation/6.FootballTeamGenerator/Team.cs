using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name, List<Player> players)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public int Rating()
        {
            if (players.Count() == 0)
            {
                return 0;
            }

            else if (this.players.Sum(s=>s.AverageCalculated()) == 0)
            {
                return 0;
            }

            else
            {
                return (int)Math.Round(this.players.Sum(s => s.AverageCalculated()) / (this.players.Count()*1.0));
            }

            


        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }

            players.Remove(players.Find(p => p.Name == playerName));
        }





    }
}
