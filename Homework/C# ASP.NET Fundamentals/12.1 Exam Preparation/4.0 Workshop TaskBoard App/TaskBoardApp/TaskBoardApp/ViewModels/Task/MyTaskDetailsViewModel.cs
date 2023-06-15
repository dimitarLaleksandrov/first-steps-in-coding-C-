using TaskBoardApp.Models.Task;

namespace TaskBoardApp.ViewModels.Task
{
    public class MyTaskDetailsViewModel : MyTaskViewModel
    {
        public string CreatedOn { get; set; } = null!;

        public string Board { get; set; } = null!;
    }
}

