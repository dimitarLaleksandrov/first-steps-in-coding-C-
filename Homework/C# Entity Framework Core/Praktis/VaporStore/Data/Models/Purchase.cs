using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporStore.Data.Models;
using VaporStore.Data.Models.Enums;

namespace VaporStore.Data.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public PurchaseType Type { get; set; }

        [Required]
        [RegularExpression(@"^([A-Z0-9]{4})\\-([A-Z0-9]{4})\\-([A-Z0-9]{4})$")]
        public string ProductKey { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey(nameof(CardId))]
        public int CardId { get; set; }

        [Required]
        public virtual Card Card { get; set; }

        [Required]
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }

        [Required]
        public virtual Game Game { get; set; }
    }
}

    //• Id – integer, Primary Key
    //• Type – enumeration of type PurchaseType, with possible values ("Retail", "Digital") (required)
    //• ProductKey – text, which consists of 3 pairs of 4 uppercase Latin letters and digits, separated by dashes (ex. "ABCD-EFGH-1J3L") (required)
    //• Date – Date (required)
    //• CardId – integer, foreign key (required)
    //• Card – the purchase's card (required)
    //• GameId – integer, foreign key (required)
    //• Game – the purchase's game (required)
