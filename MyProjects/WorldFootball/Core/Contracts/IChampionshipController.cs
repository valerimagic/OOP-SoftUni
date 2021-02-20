using System.Collections.Generic;
using Football.Models.Players.Contracts;
using Football.Models.Players.Entities;

namespace Football.Core.Contracts
{
    public interface IChampionshipController
    {
        string CreatePlayer(string name, int age, string country, string city, int idTeam);

        string RemovePlayer(Player player);

        string CreateTeam(string teamName);

    }
}
