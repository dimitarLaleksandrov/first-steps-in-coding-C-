using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Models.Board;
using TaskBoardApp.ViewModels.Task;

namespace TaskBoardApp.Contracts
{
    public interface IBoardServices
    {
        Task<IEnumerable<BoardViewModel>> AllBoardsAsync();

        Task<IEnumerable<MyTaskBoardModel>> AllForSelectAsync();

        Task<bool> ExistByIdAsync(int id);
    }
}
