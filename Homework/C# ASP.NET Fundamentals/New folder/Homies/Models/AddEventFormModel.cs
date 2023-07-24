using Homies.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Type = Homies.Data.Models.Type;

namespace Homies.Models
{
    public class AddEventFormModel
    {

        public AddEventFormModel()
        {
            this.Types = new HashSet<TypeViewModel>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(150, MinimumLength = 15)]
        public string Description { get; set; } = null!;

        public IdentityUser? Organiser { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int TypeId { get; set; }

        public Type? Type { get; set; }

        public ICollection<TypeViewModel> Types { get; set; }

    }
}
