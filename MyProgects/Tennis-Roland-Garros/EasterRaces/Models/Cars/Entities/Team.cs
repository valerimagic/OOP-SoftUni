using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Models.Cars.Entities
{
    public class Team : ITeam
    {
        private string nameCountry;
        private IDictionary<string, IPlayer> teams;

        public Team()
        {
            this.teams=new Dictionary<string, IPlayer>();
        }

        public Team(string nameCountry):this()
        {
            this.NameCountry = nameCountry;
        }

        public IDictionary<string, IPlayer> Teams { get; }

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
        public void AddTeam(IPlayer player)
        {
            throw new NotImplementedException();
        }
        public void ResultOfTheGame()
        {
            throw new NotImplementedException();
        }
    }
}
