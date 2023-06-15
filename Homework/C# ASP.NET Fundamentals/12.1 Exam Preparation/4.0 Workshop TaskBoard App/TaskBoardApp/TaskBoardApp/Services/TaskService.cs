using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Data.Models;
using TaskBoardApp.ViewModels.Task;

namespace TaskBoardApp.Services
{
    public class TaskService : ITaskServices
    {
        private readonly TaskBoardAppDbContext dbContext;
        public TaskService(TaskBoardAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task AddAsync(string ownerId, MyTaskFormModel viewModel)
        {
            var task = new MyTask()
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

        public async Task<MyTaskDetailsViewModel> GetForDetailsByIdAsync(string id)
        {
            var viewModel = await this.dbContext.Tasks
                .Select(t => new MyTaskDetailsViewModel()
                {
                    Id = t.Id.ToString(),
                    Title = t.Title,
                    Description = t.Description,
                    Owner = t.Owner.UserName,
                    CreatedOn = t.CreatedOn.ToString("f"),
                    Board = t.Board.Name
                })
                .FirstAsync(t => t.Id.ToString() == id);                                                      

            return viewModel;
        }

        public async Task<MyTaskFormModel> GetForEditByIdAsync(string id)
        {
            var task = await this.dbContext.Tasks.FindAsync(id);

            var taskModel = new MyTaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                Boards = dbContext.Boards.Select(b => new MyTaskBoardModel()
                {
                    Id = b.Id,
                    Name = b.Name
                })
            };

            return taskModel;
        }
    }
}
