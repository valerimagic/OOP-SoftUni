﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Models.Races.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : Repository<IRace>
    {
        public override IRace GetByName(string name)
        {
            var race = base.Models.FirstOrDefault(x => x.Name == name);
            return race;
        }
    }
}
