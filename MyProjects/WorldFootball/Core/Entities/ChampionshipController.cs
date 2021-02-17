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


        private List<IDictionary<string, IPlayer>> teams;
        private readonly List<IPlayer> playerss;
        

        public ChampionshipController()
        {
            teams = new List<IDictionary<string, IPlayer>>();
        }
        //public ChampionshipController()
        //{
        //    players = new List<IPlayer>();
        //}

        public string CreatePlayer(string name, int age, string country, string city)
        {
            IPlayer player = new Player(name, age, country, city);
            Team team = new Team(player.Name);


            team.AddTeam(player.Name, player);

            return string.Format(OutputMessages.PlayerCount, playerss.Count);



            //IRace race = this.raceRepository.GetByName(raceName);
            //IRider rider = this.riderRepository.GetByName(riderName);
            //race.AddRider(rider);

        }


        public string CreateTeam(string teamName)
        {

            var team = new Team(teamName);
            //team.AddTeam(teamName, playerName);
            team.AddTeam(teamName);
            //this.teams.Add();
            return string.Format(OutputMessages.TeamCreated, teamName);
        }

        public string RemovePlayer(Player player)
        {

            var playerForDelete = playerss.FirstOrDefault(x => x.Name == player.Name);
            if(playerForDelete != null)
            {
                this.playerss.Remove(playerForDelete);
                return string.Format(OutputMessages.PlayerDeleted, player.Name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.PlayerNOTExists, player.Name);
            }

        }
        


    }
}
