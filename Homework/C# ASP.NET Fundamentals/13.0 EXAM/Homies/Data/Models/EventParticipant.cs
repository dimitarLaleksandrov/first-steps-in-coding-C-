using Homies.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Models
{
    public class EventParticipant
    {
     
        public string HelperId { get; set; } = null!;

        [ForeignKey(nameof(HelperId))]
        public IdentityUser Helper { get; set; } = null!;


      
        public int EventId { get; set; }

        [ForeignKey(nameof(EventId))]
        public Event Event { get; set; } = null!;
    }
}

   