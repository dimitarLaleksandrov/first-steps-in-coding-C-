namespace FootballManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {

        public User()
        {
            this.UserPlayers = new HashSet<UserPlayer>();
        }

        [Key]
        public string Id { get; set; }


        [Required]
        [MaxLength(20)]
        public string Username { get; set; }


        [Required]
        [MaxLength(60)]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }


        public ICollection<UserPlayer> UserPlayers { get; set; } 


    }
}
