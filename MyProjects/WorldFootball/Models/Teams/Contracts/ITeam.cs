using Football.Models.Players.Contracts;
using Football.Models.Teams.Contracts;

namespace Football.Models.Teams.Contracts
{
    public interface ITeam
    {
        string NameCountry { get; }

        int Goal { get; }

        double TotalPoints { get; } 

        IPlayer Player { get; }

    }
}
