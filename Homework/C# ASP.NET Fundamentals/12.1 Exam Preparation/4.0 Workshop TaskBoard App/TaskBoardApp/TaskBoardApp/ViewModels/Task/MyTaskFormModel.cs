using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Task;


namespace TaskBoardApp.ViewModels.Task
{
    public class MyTaskFormModel
    {
        [Required]
        [StringLength(TaskMaxTitle, MinimumLength = TaskMinTitle,
             ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(TaskMaxDescription, MinimumLength = TaskMinDescription,
             ErrorMessage = "Description should be at least {2} characters long.")]
        public string Description { get; set; } = null!;

        [Display(Name = "Board")]
        public int BoardId { get; set; }
     

        public IEnumerable<MyTaskBoardModel> ?Boards { get; set; }
    }
}
