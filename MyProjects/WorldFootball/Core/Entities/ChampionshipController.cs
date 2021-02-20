using System;
using System.Collections.Generic;
using Football.Core.Contracts;
using Football.Models.Players.Contracts;
using Football.Models.Players.Entities;
using Football.Models.Teams.Entities;
using Football.Utilities.Messages;

namespace Football.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {

        private List<Team> teams;
        

        public ChampionshipController()
        {
            teams = new List<Team>();
        }


        public string CreatePlayer(string name, int age, string country, string city, int idTeam)
        {
            IPlayer player = new Player(name, age, country, city);
            int index = teams.FindIndex(x => x.id == idTeam);
            if (index > -1)
            {
                teams[index].listPlayer.Add(player);
            }

            return string.Format(OutputMessages.PlayerCount, teams.Count);

        }


        public string CreateTeam(string teamName)
        {

            Team team = new Team("", teamName);
            teams.Add(team);
            return string.Format(OutputMessages.TeamCreated, teamName);
            
        }

        public string RemovePlayer(Player player)
        {

            int index = teams.FindIndex(x => x.listPlayer.Contains(player));
            if (index > -1)
            {
                teams[index].listPlayer.Remove(player);
                return string.Format(OutputMessages.PlayerDeleted, player.Name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }

        }

        
    }
}
