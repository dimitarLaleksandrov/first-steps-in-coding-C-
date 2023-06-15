using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models;

namespace VaporStore.Data.Models
{
    public class Tag
    {
        public Tag()
        {
            this.GameTags = new HashSet<GameTag>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<GameTag> GameTags { get; set;}
    }
}
    //• Id – integer, Primary Key
    //• Name – text (required)
    //• GameTags – collection of type GameTag
