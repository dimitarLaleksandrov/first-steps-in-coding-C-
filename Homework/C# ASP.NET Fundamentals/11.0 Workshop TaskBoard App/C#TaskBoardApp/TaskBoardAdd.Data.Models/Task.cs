﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static TaskBoardAdd.Common.EntityValidationConstants.Task;

namespace TaskBoardAdd.Data.Models
{
    public class Task  
    {
        public Task()
        {
            this.Id = Guid.NewGuid();
        }


        [Key]
        public Guid Id { get; set; }


        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;


        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;


        public DateTime CreatedOn { get; set; }

        [ForeignKey(nameof(Board))]
        public int BoardId { get; set; }

        public virtual Board Board { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; } = null!;

        public virtual IdentityUser Owner { get; set; } = null!;


    }
}
