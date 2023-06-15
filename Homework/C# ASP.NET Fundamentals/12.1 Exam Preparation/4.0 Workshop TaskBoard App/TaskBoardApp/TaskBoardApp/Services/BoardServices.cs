using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Board;
using TaskBoardApp.Models.Task;
using TaskBoardApp.ViewModels.Task;

namespace TaskBoardApp.Services
{
    public class BoardServices : IBoardServices
    {
        private readonly TaskBoardAppDbContext dbContext;

        public BoardServices(TaskBoardAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<BoardViewModel>> AllBoardsAsync()
        {
            IEnumerable<BoardViewModel> allBoards = await this.dbContext.Boards
                                                                     .Select(b => new BoardViewModel
                                                                     {
                                                                         Name = b.Name,
                                                                         Tasks = b.Tasks
                                                                                   .Select(t => new MyTaskViewModel()
                                                                                   {
                                                                                       Id = t.Id.ToString(),
                                                                                       Title = t.Title,
                                                                                       Description = t.Description,
                                                                                       Owner = t.Owner.UserName
                                                                                   })
                                                                                   .ToArray()
                                                                     })
                                                                     .ToArrayAsync();

            return allBoards;
        }

        public async Task<IEnumerable<MyTaskBoardModel>> AllForSelectAsync()
        {
            IEnumerable<MyTaskBoardModel> allBoards = await this.dbContext
                .Boards
                .Select(b => new MyTaskBoardModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToArrayAsync();

            return allBoards;
        }

        public async Task<bool> ExistByIdAsync(int id)
        {
            bool result = await this.dbContext.Boards
                                        .AnyAsync(b => b.Id == id);

            return result;
        }
    }

}
