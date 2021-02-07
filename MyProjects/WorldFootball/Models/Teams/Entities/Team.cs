using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Football.Models.Players.Contracts;
using Football.Models.Teams.Contracts;
using Football.Models.StatisticsTeam.Entities;
using Football.Utilities.Messages;
using Football.Models.Players.Entities;

namespace Football.Models.Teams.Entities
{
    public class Team : ITeam
    {
        //private string nameCountry;
        private IDictionary<string, IPlayer> teams;

        public Team()
        {
            this.teams=new Dictionary<string, IPlayer>();
        }

        public Team(string nameCountry, StatisticTeam statisticTeam):this()
        {
            this.NameCountry = nameCountry;
        }

        public IDictionary<string, IPlayer> Teams { get; set; }

        public string NameCountry { get; }
        public int Goal { get; }
        public int Loss { get; }
        public int Draw { get; }
        public double TotalPoints { get; }

        public IPlayer Player { get; }

        public void CheckAndAddPlayerToTeam(IPlayer player, string country)
        {
            var playerToAdd = teams.FirstOrDefault(x => x.Key == country).Value;

            if (playerToAdd != null)
            {
                throw new ArgumentException(ExceptionMessages.PlayerExists, player.Name);
            }

            teams.Add(country, player);
            
        }

        public void AddTeam(IPlayer player, string teamName)
        {
            var addNewTeam = this.teams.FirstOrDefault(x => x.Key == teamName).Value;
            if (addNewTeam == null)
            {
                throw new ArgumentException($"Player {teamName} is not in list");
            }
            this.teams.Add(addNewTeam);
        }


        public void AddTeam(IPlayer player)
        {
            throw new NotImplementedException();
        }
        public void ResultOfTheGame()
        {
            throw new NotImplementedException();
        }

        public void AddPlayerinTeam(ITeam team)
        {
            throw new NotImplementedException();
        }


        public StatisticTeam StatisticTeam { get; }
    }
}
