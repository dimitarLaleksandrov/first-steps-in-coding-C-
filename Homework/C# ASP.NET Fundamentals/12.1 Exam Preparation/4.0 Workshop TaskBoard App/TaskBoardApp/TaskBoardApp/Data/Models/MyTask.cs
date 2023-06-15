using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TaskBoardApp.Data.DataConstants.Task;

namespace TaskBoardApp.Data.Models
{
    public class MyTask
    {
        public MyTask()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }


        [Required]
        [StringLength(TaskMaxTitle)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(TaskMaxDescription)]
        public string Description { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        [ForeignKey(nameof(Board))]
        public int BoardId { get; set;}

        public virtual Board Board { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set;} = null!;

        public virtual IdentityUser Owner { get; set; } = null!;

    }
}
