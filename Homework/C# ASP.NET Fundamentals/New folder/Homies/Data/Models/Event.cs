﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Homies.Data.Models
{
    public class Event
    {
        public Event()
        {
            this.EventsParticipants = new HashSet<EventParticipant>();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = null!;

        [Required]
        public string OrganiserId { get; set; } = null!;

        [Required]
        public IdentityUser Organiser { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; } 

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]       
        public int TypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

         
        public ICollection<EventParticipant> EventsParticipants { get; set; }


    }
}

   