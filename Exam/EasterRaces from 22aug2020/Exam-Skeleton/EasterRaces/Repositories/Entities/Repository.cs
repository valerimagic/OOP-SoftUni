using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public abstract class Repository<T> : IRepository<T>
    {
        private List<T> models;


        protected Repository()
        {
            this.models = new List<T>();
        }


        public IReadOnlyCollection<T> Models => (IReadOnlyCollection<T>)this.models;


        public void Add(T model)
        {
            this.models.Add(model);
        }

        public bool Remove(T model)
        {
            return this.models.Remove(model);
        }

        public abstract T GetByName(string name);


        public IReadOnlyCollection<T> GetAll()
        {
            return this.Models;
        }

    }
}
