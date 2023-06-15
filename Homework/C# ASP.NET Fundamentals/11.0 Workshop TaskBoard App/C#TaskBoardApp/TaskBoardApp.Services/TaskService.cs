using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Data;
using TaskBoardApp.Services.Interfaces;
using TaskBoardApp.Web.ViewModels.Board;
using TaskBoardApp.Web.ViewModels.Task;

namespace TaskBoardApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskBoardDbContext dbContext;
        public TaskService(TaskBoardDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(string ownerId, TaskFormModel viewModel)
        {
            TaskBoardAdd.Data.Models.Task task = new TaskBoardAdd.Data.Models.Task()
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                BoardId = viewModel.BoardId,
                CreatedOn = DateTime.UtcNow,
                OwnerId = ownerId,
            };

            await this.dbContext.Tasks.AddAsync(task);
            await this.dbContext.SaveChangesAsync();

        }

        public async Task<TaskDetailsViewModel> GetForDetailsByIdAsync(string id)
        {
            TaskDetailsViewModel viewModel = await this.dbContext.Tasks
                                                           .Select(t => new TaskDetailsViewModel()
                                                           {
                                                               Id = t.Id.ToString(),
                                                               Title = t.Title,
                                                               Description = t.Description,
                                                               Owner = t.Owner.UserName,
                                                               CreatedOn = t.CreatedOn.ToString("f"),
                                                               Board = t.Board.Name
                                                           })
                                                           .FirstAsync(t => t.Id == id);

            return viewModel;

        }

        public async Task<TaskFormModel> GetForEditByIdAsync(string id)
        {
            var task = await this.dbContext.Tasks.FindAsync(id);

            var taskModel = new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                AllBoards = dbContext.Boards.Select(b => new BoardSelectViewModel()
                {
                    Id = b.Id,
                    Name = b.Name
                })
            };

            return taskModel;
        }

    }
}
