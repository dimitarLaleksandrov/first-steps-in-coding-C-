
using Forum.App.Data.Configuration;
using Forum.Data.Mode;
using Microsoft.EntityFrameworkCore;

namespace Forum.App.Data
{

    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostEntityConfoguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
