using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
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
        private readonly List<IPlayer> playerss;
        

        public ChampionshipController()
        {
            teams = new List<Team>();
        }

        //public ChampionshipController() => teams = new List<Team>();
        //{
        //    players = new List<IPlayer>();
        //}

        public string CreatePlayer(string name, int age, string country, string city, int idTeam)
        {
            IPlayer player = new Player(name, age, country, city);
            //Team team = new Team(player.Name);
            int index = teams.FindIndex(x => x.id == idTeam);
            if (index > -1)
            {
                teams[index].listPlayer.Add(player);
            }

            //team.AddTeam(player.Name, player);

            return string.Format(OutputMessages.PlayerCount, playerss.Count);



            //IRace race = this.raceRepository.GetByName(raceName);
            //IRider rider = this.riderRepository.GetByName(riderName);
            //race.AddRider(rider);

        }


        public string CreateTeam(string teamName)
        {

            Team team = new Team("", teamName);
            //team.AddTeam(teamName, playerName);
            teams.Add(team);
            //this.teams.Add();
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
            //var playerForDelete = .FirstOrDefault(x => x.Name == player.Name);
            //if(playerForDelete != null)
            //{
            //    this.playerss.Remove(playerForDelete);
            //    return string.Format(OutputMessages.PlayerDeleted, player.Name);
            //}
            //else
            //{
            //}

        }

        public string CreatePlayer(string name, int age, string country, string city)
        {
            throw new NotImplementedException();
        }
    }
}
