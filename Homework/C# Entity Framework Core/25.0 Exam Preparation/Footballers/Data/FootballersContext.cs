namespace Footballers.Data
{
    using Footballers.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class FootballersContext : DbContext
    {
        public FootballersContext() 
        { 

        }

        public FootballersContext(DbContextOptions options)
            : base(options) 
        { 

        }
        public DbSet<Team> TeamsSecond { get; set; }

        public DbSet<Footballer> FootballersSecond { get; set; }

        public DbSet<Coach> CoachesSecond { get; set; }

        public DbSet<TeamFootballer> TeamsFootballersSecond { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString)
                    .UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamFootballer>()
                .HasKey(tf => new
                {
                    tf.TeamId,
                    tf.FootballerId
                });
        }
    }
}
