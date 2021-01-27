namespace RolandGarros.Core.Contracts
{
    public interface IChampionshipController
    {
        string CreatePlayer(string name, int age, string country, string city, int numberOfPlayedMatchs, int win, int loss);

        string CreateCar(string type, string model, int horsePower);

        string CreateTournament(string name, int maxCountPlayer);

        string AddDriverToRace(string raceName, string driverName);

        string AddCarToDriver(string driverName, string carModel);

        string StartTournament(string tournamentName);
    }
}
