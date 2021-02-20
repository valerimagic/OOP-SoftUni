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
        public Team(string nameCountry, string name) : this()
        {
            this.NameCountry = nameCountry;
            this.name = name;
        }


    }
}
