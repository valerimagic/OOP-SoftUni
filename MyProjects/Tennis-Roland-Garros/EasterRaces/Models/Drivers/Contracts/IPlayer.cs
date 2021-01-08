using EasterRaces.Models.Cars.Contracts;

namespace EasterRaces.Models.Drivers.Contracts
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

        void AddPlayerinTeam(ITeam team);

        //ITeam Team { get; }
    }
        
}