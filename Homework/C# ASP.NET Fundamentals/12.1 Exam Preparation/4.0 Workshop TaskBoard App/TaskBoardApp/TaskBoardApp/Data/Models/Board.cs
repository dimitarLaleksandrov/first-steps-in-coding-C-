using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.Board;

namespace TaskBoardApp.Data.Models
{
    public class Board
    {
        public Board()
        {
            this.Tasks = new HashSet<MyTask>();
        }

        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(BoardMaxName)]
        public string Name { get; set; } = null!;

        
        public ICollection<MyTask> Tasks { get; set; } 
    }
}
