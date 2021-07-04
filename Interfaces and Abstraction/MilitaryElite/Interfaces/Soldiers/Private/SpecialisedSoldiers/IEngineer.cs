using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces.Soldiers.Private.SpecialisedSoldiers
{
    public interface IEngineer
    {
        IReadOnlyList<Repair> Repairs { get; }
    }
}
