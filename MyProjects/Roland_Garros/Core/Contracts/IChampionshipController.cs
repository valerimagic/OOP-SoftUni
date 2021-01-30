namespace RolandGarros.Core.Contracts
{
    public interface IChampionshipController
    {
        string CreatePlayer(string name, int age, string country, string city, int numberOfPlayedMatchs, int win, int loss);

        string CreateTournament(string name, int maxCountPlayer);

        string StartTournament(string tournamentName);
    }
}
