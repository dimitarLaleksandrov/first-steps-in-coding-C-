using Footballers.Data.Models;
using Footballers.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.Data.Models
{
    public class Footballer
    {
        public Footballer()
        {
            this.TeamsFootballers = new HashSet<TeamFootballer>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; } = null!;

        [Required]
        public virtual DateTime ContractStartDate { get; set; }

        [Required]
        public virtual DateTime ContractEndDate { get; set; }

        [Required]
        public virtual PositionType PositionType { get; set; }

        [Required]
        public virtual BestSkillType BestSkillType { get; set; }

        [Required]
        [ForeignKey(nameof(CoachId))]
        public int CoachId { get; set;}

        public virtual Coach Coach { get; set; }

        public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; }
    }
}
