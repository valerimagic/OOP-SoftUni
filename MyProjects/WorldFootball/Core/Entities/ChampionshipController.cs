namespace Football.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dataaccess.Entity;
    using Football.Core.Contracts;
    using Football.Models.Players.Contracts;
    using Football.Models.Players.Entities;
    using Football.Models.StatisticsTeam.Entities;
    using Football.Models.Teams.Entities;
    using Football.Utilities.Messages;

    public class ChampionshipController : IChampionshipController
    {
        private FootballDbContext servise;

        private List<Team> teams;

        private Teams entityTeam;

        public ChampionshipController()
        {
            this.teams = new List<Team>();
            this.servise = new FootballDbContext();
        }

        private HashSet<Players> Play { get; set; } = new HashSet<Players>();

        public string CreatePlayer(string name, int age, string country, string city, int idTeam)
        {
            IPlayer player = new Player(name, age, country, city);

            Team team = this.teams.FirstOrDefault(x => x.NameCountry == country);
            
            if (team == null)
            {
                return string.Format(OutputMessages.TeamsIsEmpty, country);
            }

            var current_player = team.ListPlayer.Where(x => x.Name == name).FirstOrDefault();

            if (current_player is null)
            {
                return string.Format(OutputMessages.PlayerIsNotCreated, name);
            }

            Players modelPlayer = new Players();
            modelPlayer.Name = player.Name;
            modelPlayer.Age = player.Age;
            modelPlayer.City = player.City;
            modelPlayer.Country = player.Country;

            team.AddPlayer(player);
            this.entityTeam.Players.Add(modelPlayer);
            this.servise.Players.Add(modelPlayer);

            return string.Format(OutputMessages.PlayerCount, this.teams.Count);
        }

        public string Save()
        {
            this.servise.Teams.Add(this.entityTeam);
            this.servise.SaveChangesAsync(); //asinc???
            return string.Empty;
        }

        public string CreateTeam(string teamName)
        {
            Team team = new Team(teamName, teamName, this.teams);
            this.entityTeam = new Teams();
            this.entityTeam.NameCountry = teamName;
            this.entityTeam.Name = teamName;
            this.teams.Add(team);
            return string.Format(OutputMessages.TeamCreated, teamName);
        }

        public string RemovePlayer(Player player)
        {
            int index = -1;
            bool isCatched = false;
            foreach (var item in this.teams)
            {
                foreach (var item_player in item.ListPlayer)
                {
                    if (item_player.Name == player.Name)
                    {
                        index++;
                        isCatched = true;
                        break;
                    }

                    index++;
                }

                if (isCatched)
                {
                    break;
                }

                index = -1;
            }

            if (index > -1)
            {
                this.teams[index].ListPlayer.RemoveAt(index);
                return string.Format(OutputMessages.PlayerDeleted, player.Name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }
        }

        public string AddStatistic(int a, int b, int c, int d, int team_id)
        {
            try
            {
                int index = this.teams.FindIndex(x => x.ID == team_id);
                if (index < 0)
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNOTExists, "No elements");
                }

                this.teams[index].Statistic = new StatisticTeam(a, b, c, d);
                return string.Format(OutputMessages.PlayerDeleted, "Enter infoation for statustic");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, ex.Message);
            }
        }
    }
}
