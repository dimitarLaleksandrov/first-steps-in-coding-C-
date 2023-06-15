using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardApp.Web.ViewModels.Board;
using static TaskBoardAdd.Common.EntityValidationConstants.Task;

namespace TaskBoardApp.Web.ViewModels.Task
{
    public class TaskFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = "Title should be at least {2} characters long.")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = "Description should be at least {2} characters long.")]
        public string Description { get; set; } = null!;


        [Display(Name = "Board")]
        public int BoardId { get; set; }

        public IEnumerable<BoardSelectViewModel> ?AllBoards { get; set; }
    }
}
