using BusStation.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace BusStation.Data
{
    public class BusStationDbContext : DbContext
    {

        

        public DbSet<Ticket> Tickets { get; set; } 

        public DbSet<User> Users { get; set; }


        public DbSet<Destination> Destinations { get; set; }







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LLKQ9MN;Database=BusStation;Integrated Security = true; TrustServerCertificate=True;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasKey(x => new 
            { 
                x.UserId, x.DestinationId
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
