

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusStation.Data.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }


        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]

        public User User { get; set; } = null!;


        public int DestinationId { get; set; }

        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; } = null!;
    }
}
    //• Has Id – an int, Primary Key
    //• Has Price – a decimal, between 10 and 90
    //• Has UserId – an int
    //• Has DestinationId – an int