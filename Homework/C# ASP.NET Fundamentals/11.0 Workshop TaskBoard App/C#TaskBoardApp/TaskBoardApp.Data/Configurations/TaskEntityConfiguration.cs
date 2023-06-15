using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = TaskBoardAdd.Data.Models.Task;

//namespace TaskBoardApp.Data.Configurations
//{
//    internal class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
//    {
//        public void Configure(EntityTypeBuilder<Task> builder)
//        {
//            builder.HasOne(t => t.Board)
//                    .WithMany(b => b.Tasks)
//                    .HasForeignKey(t => t.BoardId)
//                    .OnDelete(DeleteBehavior.Restrict);


//            builder.HasData(this.GenerateTasks);
//        }

//        private ICollection<Task> GenerateTasks()
//        {
//            ICollection<Task> tasks = new HashSet<Task>()
//            {
//                new Task()
//                {
//                    Title = "Improve CSS styles",
//                    Description = "Implement better styling for all public pages",
//                    CreatedOn = DateTime.UtcNow.AddDays(-200),
//                    OwnerId = "",
//                    BoardId = 2
                    
//                },
//                new Task()
//                {
//                    Title = "Android Client App",
//                    Description = "Create Android Client app for the TaskBoard Restful API",
//                    CreatedOn = DateTime.UtcNow.AddMonths(-5),
//                    OwnerId = "",
//                    BoardId = 2

//                }
//            };
//            return tasks;
//        }
//    }
//}
