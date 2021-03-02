using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Dataaccess.Entity;

namespace Dataaccess.Entity
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Teams> Teams { get; set; } 

        public DbSet<Players> Players { get; set; } 

        public DbSet<Statistics> Statistics { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DataSettings.DefaultConnection);
            }
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Teams>()
        //        .HasMany(p => p.Players)
        //        .WithOne(t => t.Teams)
        //        .HasForeignKey(t => t.TeamId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
