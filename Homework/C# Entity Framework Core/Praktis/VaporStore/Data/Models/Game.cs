using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Purchases = new HashSet<Purchase>();
            this.GameTags = new HashSet<GameTag>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0.0f, (double)decimal.MaxValue )]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [ForeignKey(nameof(DeveloperId))]
        public int DeveloperId { get; set; }

        [Required]
        public virtual Developer Developer { get; set; }

        [Required]
        [ForeignKey(nameof(GenreId))]
        public int GenreId { get; set; }

        [Required]
        public virtual Genre Genre { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
        public virtual ICollection<GameTag> GameTags { get; set; }

    }
}


    //• Id – integer, Primary Key
    //• Name – text (required)
    //• Price – decimal (non-negative, minimum value: 0) (required)
    //• ReleaseDate – Date (required)
    //• DeveloperId – integer, foreign key (required)
    //• Developer – the game's developer (required)
    //• GenreId – integer, foreign key (required)
    //• Genre – the game's genre (required)
    //• Purchases - collection of type Purchase
    //• GameTags - collection of type GameTag. Each game must have at least one tag.