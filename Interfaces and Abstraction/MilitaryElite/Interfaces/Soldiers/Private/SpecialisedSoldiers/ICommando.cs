using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MilitaryElite.Interfaces.Soldiers.Private.SpecialisedSoldiers
{
    public interface ICommando
    {
        IReadOnlyList<Mission> Missions{ get; }
    }
}
