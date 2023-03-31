using Artillery.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artillery.Data.Models
{
    public class CountryGun
    {
        [Key]
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        [Key]
        [ForeignKey(nameof(GunId))]
        public int GunId { get; set; }
    }
}
    //• CountryId – Primary Key integer, foreign key (required)
    //• GunId – Primary Key integer, foreign key (required)
