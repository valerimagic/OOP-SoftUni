using EasterRaces.Models.Drivers.Contracts;

namespace EasterRaces.Models.Cars.Contracts
{
    public interface ITeam
    {
        string NameCountry { get; }

        int Goal { get; }

        int Loss { get; }
        
        int Draw { get; }

        double TotalPoints { get; } // общия брой точки от срещите

        //double CubicCentimeters { get; }

        //double CalculatePoints(int laps);

        void ResultOfTheGame(); // калкулира логиката как е свършила срещата

        IPlayer Player { get; }

        void AddTeam(IPlayer player);
    }
}
