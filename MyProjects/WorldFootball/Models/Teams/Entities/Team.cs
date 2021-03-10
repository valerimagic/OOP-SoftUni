namespace Football.Models.Teams.Entities
{
    using System;
    using System.Collections.Generic;
    using Football.Models.Players.Contracts;
    using Football.Models.Players.Entities;
    using Football.Models.StatisticsTeam.Entities;
    using Football.Utilities.Messages;

    public class Team
    {
        private int id;
        private string name;
        private List<IPlayer> listPlayer;
        private StatisticTeam statistic;

        public Team()
        {
            this.listPlayer = new List<IPlayer>();
            this.statistic = new StatisticTeam();
        }

        public Team(string nameCountry, string name, List<Team> list) : this()
        {
            this.NameCountry = nameCountry;
            this.name = name;
            this.GenerateID(list);
        }

        public int ID => this.id;

        public List<IPlayer> ListPlayer
        {
            get { return this.listPlayer; }
        }

        public StatisticTeam Statistic
        {
            get { return this.statistic; }
            set { this.statistic = value; }
        }

        public string NameCountry { get; set; }

        public void AddPlayer(IPlayer player)
        {
            if (this.listPlayer.Count != 0)
            {
                if (!this.listPlayer.Contains(player))
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
                }
            }

            this.listPlayer.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            if (!this.listPlayer.Contains(player))
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }

            this.listPlayer.Remove(player);
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
