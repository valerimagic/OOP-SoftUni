using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        public IReadOnlyCollection<IGun> Models => throw new NotImplementedException();

        public void Add(IGun model)
        {
            throw new NotImplementedException();
        }

        public IGun FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IGun model)
        {
            throw new NotImplementedException();
        }
    }
}
