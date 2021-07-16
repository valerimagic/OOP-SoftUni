using System;
using System.Collections.Generic;
using System.Text;
using Dataaccess.Entity;
using Microsoft.EntityFrameworkCore;


namespace Dataaccess
{
    public class GenericRepository<Tentiry>
        where Tentiry : BaseClass
    {
        private FootballDbContext _context;
        //private DbSet<>
        public GenericRepository()
        {
            _context = new FootballDbContext();
        }
        public void GetAll()
        {

        }

        public void Add()
        {

        }

        public void Update()
        {
        }

        public void Delete()
        {

        }

        public void Save()
        {
            //if ()
            //{
                
            //}
        }

    }
}
