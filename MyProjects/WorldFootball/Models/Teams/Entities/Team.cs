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
        private int id;
        private string name;
        private  List<IPlayer> listPlayer;
        private StatisticTeam statistic;

        public int ID
        {
            get { return this.id; }
        }

        public List<IPlayer> ListPlayer
        {
            get { return this.listPlayer; }
        }
        public StatisticTeam Statistic
        {
            get { return this.statistic; }
            set { this.statistic = value; }
        }
        public string NameCountry;
        public Team()
        {
            listPlayer = new List<IPlayer>();
            statistic = new StatisticTeam();
        }
        public Team(string nameCountry, string name, List<Team> list) : this()
        {
            this.NameCountry = nameCountry;
            this.name = name;
            GenerateID(list);
        }

        public void AddPlayer(IPlayer player)
        {
            if (listPlayer.Count != 0)
            {
                if (!listPlayer.Contains(player))
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
                }
            }
           

            listPlayer.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            if (!listPlayer.Contains(player))
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }

            listPlayer.Remove(player);
        }

        private void GenerateID(List<Team> list)
        {
            if (list.Count == 0)
            {
                this.id = 1;
                return;
            }
            this.id = list[list.Count - 1].id + 1;
        }
    }
}
