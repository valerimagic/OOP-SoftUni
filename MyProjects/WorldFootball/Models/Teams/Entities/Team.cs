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
    public class Team 
    {
        public int id;
        public string name;
        public List<IPlayer> listPlayer;
        public StatisticTeam statistic;

        public string NameCountry;
        public Team()
        {
            listPlayer = new List<IPlayer>();
            statistic = new StatisticTeam();
        }
        public Team(string nameCountry, string name) : this()//, StatisticTeam statisticTeam)
        {
            this.NameCountry = nameCountry;
            this.name = name;
        }

        //public IDictionary<string, List<IPlayer>> Teams => this.team;


        //getset
       

        //public void CheckAndAddPlayerToTeam(IPlayer player, string country)
        //{
        //    var playerToAdd = team.FirstOrDefault(x => x.Key == country).Value;

        //    if (playerToAdd != null)
        //    {
        //        throw new ArgumentException(ExceptionMessages.PlayerExists, player.Name);
        //    }

        //    team.Add(country, player);
            
        //}

        //public void AddTeam(string name)
        //{
        //    var addNewTeam = this.team.FirstOrDefault(x => x.Key.Contains(playerName)).Value;
        //    if (addNewTeam != null)
        //    {
        //        throw new ArgumentException($"Team {playerName} is already in list");
        //    }
        //    this.team.Add(player.Name, player);
        //}



    }
}
