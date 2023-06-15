using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskBoardAdd.Common.EntityValidationConstants.Board;

namespace TaskBoardAdd.Data.Models
{
    public class Board
    {
        public Board()
        {
            this.Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
