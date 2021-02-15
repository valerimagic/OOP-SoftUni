using System.Dynamic;
using Football.Models.Players.Contracts;
using Football.Models.Players.Entities;
using Football.Models.Teams.Contracts;

namespace Football.Models.Players.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        int Age { get; }

        string Country { get; }

        string City { get; }

        int NumberOfPlayedMatchs{ get; }

        int Win { get; set; }

        int Loss { get; set; }

        bool CanParticipate { get; set; }

        void AddPlayer (string name, int age, string country, string city);

        void RemovePlayer(Player player);

       
    }
        
}