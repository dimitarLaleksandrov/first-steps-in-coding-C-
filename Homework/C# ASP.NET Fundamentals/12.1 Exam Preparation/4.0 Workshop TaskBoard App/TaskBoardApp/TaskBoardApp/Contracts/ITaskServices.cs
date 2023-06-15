using TaskBoardApp.ViewModels.Task;

namespace TaskBoardApp.Contracts
{
    public interface ITaskServices
    {
        Task AddAsync(string ownerId, MyTaskFormModel viewModel);

        Task<MyTaskDetailsViewModel> GetForDetailsByIdAsync(string id);

        Task<MyTaskFormModel> GetForEditByIdAsync(string id);

    }
}
