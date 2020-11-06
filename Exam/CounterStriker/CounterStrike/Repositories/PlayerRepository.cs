using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        public IReadOnlyCollection<IPlayer> Models => throw new NotImplementedException();

        public void Add(IPlayer model)
        {
            throw new NotImplementedException();
        }

        public IPlayer FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IPlayer model)
        {
            throw new NotImplementedException();
        }
    }
}
