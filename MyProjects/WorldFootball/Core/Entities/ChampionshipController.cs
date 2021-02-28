using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Dataaccess.Entity;
using Football.Core.Contracts;
using Football.Models.Players.Contracts;
using Football.Models.Players.Entities;
using Football.Models.StatisticsTeam.Entities;
using Football.Models.Teams.Entities;
using Football.Utilities.Messages;

namespace Football.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private FootballDbContext _servise;

        private List<Team> teams;


        public ChampionshipController()
        {
            teams = new List<Team>();
            _servise = new FootballDbContext();
        }


        public string CreatePlayer(string name, int age, string country, string city, int idTeam)
        {



            IPlayer player = new Player(name, age, country, city);
            //Team team;
            
            
            Team team = teams.FirstOrDefault(x => x.NameCountry == country);
            // validation of team is null
            if (team is null)
            {
                // return exception
            }
            var current_player = team.ListPlayer.Where(x => x.Name == name).FirstOrDefault();
            if (current_player is null)
            {
                // return exception
            }

            Players model_player = new Players();
            model_player.Name = player.Name;
            model_player.Age = player.Age;
            model_player.City = player.City;
            model_player.Country = player.Country;

            team.AddPlayer(player);
            entityTeam.Players.Add(model_player);
            _servise.Players.Add(model_player);

            //int index = teams.FindIndex(x => x.id == idTeam);
            //if (index > -1)
            //{

            //    //teams[index].listPlayer.Add(player);
            //}

            return string.Format(OutputMessages.PlayerCount, teams.Count);
        }

        public string Save()
        {
            _servise.Teams.Add(entityTeam);
            _servise.SaveChangesAsync();
            return "";
        }
        HashSet<Players> play = new HashSet<Players>();
        private Teams entityTeam;
        public string CreateTeam(string teamName)
        {

            Team team = new Team(teamName, teamName, teams);
            entityTeam = new Teams();
            entityTeam.NameCountry = teamName;
            entityTeam.Name = teamName;
            teams.Add(team);
            return string.Format(OutputMessages.TeamCreated, teamName);

        }

        public string RemovePlayer(Player player)
        {

            int index = -1;
            bool isCatched = false;
            foreach (var item in teams)
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
                teams[index].ListPlayer.RemoveAt(index);
                return string.Format(OutputMessages.PlayerDeleted, player.Name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }

        }

        public string AddStatistic(int a , int b,  int c, int d, int team_id)
        {
            try
            {
                int index = teams.FindIndex(x => x.ID == team_id);
                if (index < 0)
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNOTExists, "No elements");
                }
                teams[index].Statistic = new StatisticTeam(a, b, c, d);
                return string.Format(OutputMessages.PlayerDeleted, "Enter infoation for statustic");
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, ex.Message);
            }
            
        }

    }
}
