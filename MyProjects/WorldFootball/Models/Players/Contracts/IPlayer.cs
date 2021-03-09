namespace Football.Models.Players.Contracts
{
    public interface IPlayer
    {
        string Name { get; }

        int Age { get; }

        string Country { get; }

        string City { get; }

        int NumberOfPlayedMatchs { get; }

        int Win { get; set; }

        int Loss { get; set; }

        bool CanParticipate { get; set; }
    }
}