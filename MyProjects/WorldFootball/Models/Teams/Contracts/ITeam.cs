namespace Football.Models.Teams.Contracts
{
    using Football.Models.Players.Contracts;

    public interface ITeam
    {
        string NameCountry { get; }

        int Goal { get; }

        double TotalPoints { get; }

        IPlayer Player { get; }
    }
}
