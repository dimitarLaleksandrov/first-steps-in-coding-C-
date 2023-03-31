namespace Footballers.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Shared;

    public class Coach
    {
        public Coach()
        {
            this.Footballers = new HashSet<Footballer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CoachNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Nationality { get; set; } = null!;

        public ICollection<Footballer> Footballers { get; set; }
    }
}
