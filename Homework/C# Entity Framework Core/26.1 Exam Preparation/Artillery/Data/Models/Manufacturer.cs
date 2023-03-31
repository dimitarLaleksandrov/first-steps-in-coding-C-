using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artillery.Data.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Guns = new HashSet<Gun>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(40)]
        public string ManufacturerName { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Founded { get; set; }

        public virtual ICollection<Gun> Guns { get; set; }
    }
}
    //• Id – integer, Primary Key
    //• ManufacturerName – unique text with length [4…40] (required)
    //• Founded – text with length [10…100] (required)
    //• Guns – a collection of Gun
