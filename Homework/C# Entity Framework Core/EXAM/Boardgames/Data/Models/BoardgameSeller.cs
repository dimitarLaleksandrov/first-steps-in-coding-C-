using Boardgames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class BoardgameSeller
    {
        [Key]
        [ForeignKey(nameof(BoardgameId))]
        public int BoardgameId { get; set; }

        public virtual Boardgame Boardgame { get; set; }

        [Key]
        [ForeignKey(nameof(SellerId))]
        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
    //• BoardgameId – integer, Primary Key, foreign key (required)
    //• Boardgame – Boardgame
    //• SellerId – integer, Primary Key, foreign key (required)
    //• Seller – Seller
