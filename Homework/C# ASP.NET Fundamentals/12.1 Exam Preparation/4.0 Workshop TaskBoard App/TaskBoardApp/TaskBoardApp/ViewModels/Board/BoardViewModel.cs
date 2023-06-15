using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Data.Models;
using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Models.Board
{
    public class BoardViewModel
    {
        public int Id { get; set; }


        public string Name { get; set; } = null!;


        public ICollection<MyTaskViewModel> Tasks { get; set; } = null!;
    }
}
