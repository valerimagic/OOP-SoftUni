namespace Dataaccess.Entity
{
    using Microsoft.EntityFrameworkCore;

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
    }
}
