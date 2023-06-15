using System.ComponentModel.DataAnnotations;


namespace BusStation.Data.Models
{
    public class User
    {
        public User()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(60)]
        public string Email { get; set; } = null!;


        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; }
    }
}
    //• Has an Id – an string, Primary Key
    //• Has a Username – a string with min length 5 and max length 20 (unique, required)
    //• Has an Email – a string with min length 10 and max length 60 (unique, required)
    //• Has a Password – a string with min length 5 and max length 20 (before hashed)  -no max length required for a hashed password in the database (required)
    //• Has Tickets collection