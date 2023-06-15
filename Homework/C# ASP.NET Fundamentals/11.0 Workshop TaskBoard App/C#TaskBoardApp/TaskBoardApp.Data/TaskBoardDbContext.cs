using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskBoardAdd.Data.Models;
using Task = TaskBoardAdd.Data.Models.Task;

namespace TaskBoardApp.Data
{
    public class TaskBoardDbContext : IdentityDbContext<IdentityUser>
    {
        public TaskBoardDbContext(DbContextOptions<TaskBoardDbContext> options)
            : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; } = null!;
        public DbSet<Board> Boards { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(TaskBoardDbContext)) ?? Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);

        }

    }
}