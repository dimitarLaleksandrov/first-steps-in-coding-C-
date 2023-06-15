using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskBoardApp.Data.Models;

namespace TaskBoardApp.Data
{
    public class TaskBoardAppDbContext : IdentityDbContext<IdentityUser>
    {
        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Board> Boards { get; set; } = null!;

        public DbSet<MyTask> Tasks { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {   

            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(TaskBoardAppDbContext)) ?? Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
          

        }
    }
}