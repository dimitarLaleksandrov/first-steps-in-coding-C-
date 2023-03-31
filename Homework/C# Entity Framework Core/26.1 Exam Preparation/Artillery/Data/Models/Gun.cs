using Artillery.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artillery.Data.Models
{
    public class Gun
    {
        public Gun()
        {
            this.Guns = new HashSet<Gun>();
            this.CountriesGuns = new HashSet<CountryGun>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(ManufacturerId))]
        public int ManufacturerId { get; set; }

        [Required]
        [Range(100, 1350000)]
        public int GunWeight { get; set; }

        [Required]
        [Range(2.00, 35.00)]
        public double BarrelLength { get; set; }

        public int? NumberBuild { get; set; }

        [Required]
        [Range(1, 100000)]
        public int Range { get; set; }

        [Required]
        public virtual GunType GunType { get; set; }

        public virtual ICollection<Gun> Guns { get; set; }

        [Required]
        [ForeignKey(nameof(ShellId))]
        public int ShellId { get; set; }

        public virtual ICollection<CountryGun> CountriesGuns { get; set; }
    }
}
    //• Id – integer, Primary Key
    //• ManufacturerId – integer, foreign key (required)
    //• GunWeight– integer in range [100…1_350_000] (required)
    //• BarrelLength – double in range [2.00….35.00] (required)
    //• NumberBuild – integer
    //• Range – integer in range [1….100_000] (required)
    //• GunType – enumeration of GunType, with possible values (Howitzer, Mortar, FieldGun, AntiAircraftGun, MountainGun, AntiTankGun) (required)
    //• ShellId – integer, foreign key (required)
    //• CountriesGuns – a collection of CountryGun
