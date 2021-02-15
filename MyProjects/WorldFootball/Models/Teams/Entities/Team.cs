using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Football.Models.Players.Contracts;
using Football.Models.Teams.Contracts;
using Football.Models.StatisticsTeam.Entities;
using Football.Utilities.Messages;
using Football.Models.Players.Entities;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Football.Models.Teams.Entities
{
    public class Team : ITeam
    {
        private IDictionary<string, List<IPlayer>> team;

        public Team()
        {
            this.team = new Dictionary<string, List<IPlayer>>();
        }

        public Team(IDictionary<string, List<IPlayer>> team)
        {
            this.team = team;
        }

        public Team(string nameCountry) : this()//, StatisticTeam statisticTeam)
        {
            this.NameCountry = nameCountry;
        }

        public IDictionary<string, List<IPlayer>> Teams => this.team;

        public string NameCountry { get; set; }
        public int Goal { get; }
        
        
        public double TotalPoints { get; }

        public IPlayer Player { get; }

        public void CheckAndAddPlayerToTeam(IPlayer player, string country)
        {
            var playerToAdd = team.FirstOrDefault(x => x.Key == country).Value;

            if (playerToAdd != null)
            {
                throw new ArgumentException(ExceptionMessages.PlayerExists, player.Name);
            }

            team.Add(country, player);
            
        }

        public void AddTeam(string playerName, IPlayer player)
        {
            var addNewTeam = this.team.FirstOrDefault(x => x.Key.Contains(playerName)).Value;
            if (addNewTeam != null)
            {
                throw new ArgumentException($"Team {playerName} is already in list");
            }
            this.team.Add(playerName, player);
        }



        public StatisticTeam StatisticTeam { get; }

    }
}
