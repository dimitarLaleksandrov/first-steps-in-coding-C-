using Footballers.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.TeamsFootballers = new HashSet<TeamFootballer>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        [RegularExpression(@"^[A-Za-z0-9\s\.\-]{3,}$")]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string Nationality { get; set; }

        public int Trophies { get; set; }

        public virtual ICollection<TeamFootballer> TeamsFootballers { get; set; }
    }
}

    //• Id – integer, Primary Key
    //• Name – text with length [3, 40]. Should contain letters (lower and upper case), digits, spaces, a dot sign ('.') and a dash ('-'). (required)
    //• Nationality – text with length [2, 40] (required)
    //• Trophies – integer (required)
    //• TeamsFootballers – collection of type TeamFootballer
