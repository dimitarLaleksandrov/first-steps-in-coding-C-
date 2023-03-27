using Footballers.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.Data.Models
{
    public class TeamFootballer
    {
        [Key]
        [ForeignKey(nameof(Team))]
        [Required]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        [Key]
        [ForeignKey(nameof(FootballerId))]
        [Required]
        public int FootballerId { get; set; }
        public virtual Footballer Footballer { get; set; }
    }
}
