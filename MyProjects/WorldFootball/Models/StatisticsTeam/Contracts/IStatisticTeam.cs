using Football.Models.StatisticsTeam.Contracts;

namespace Football.Models.StatisticsTeam.Contracts
{
    using System.Collections.Generic;

    public interface IStatisticTeam
    {
        string Name { get; }

        int Laps { get; }

        //IReadOnlyCollection<IDriver> Drivers { get; }

        //void AddDriver(IDriver driver);
    }
}