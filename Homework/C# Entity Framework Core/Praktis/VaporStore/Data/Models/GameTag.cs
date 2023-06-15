using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models;

namespace VaporStore.Data.Models
{
    public class GameTag
    {
        [Key]
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        [Key]
        [ForeignKey(nameof(TagId))]
        public int TagId { get; set; }

        public virtual Tag? Tag { get; set; }
    }
}
    //• GameId – integer, Primary Key, foreign key (required)
    //• Game – Game
    //• TagId – integer, Primary Key, foreign key (required)
    //• Tag – Tag
