using DAL.ConnectionString;
using DAL.Entiies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataContext
{
    public class PhoneDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<RegistrationDetail> RegistrationDetails { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.DefaultConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasMany(c => c.ContactID)
                .WithOne(u => u.UserId);
        }
    }
}
