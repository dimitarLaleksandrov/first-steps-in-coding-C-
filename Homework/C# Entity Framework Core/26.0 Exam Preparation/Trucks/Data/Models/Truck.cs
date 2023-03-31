using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models.Enums;

namespace Trucks.Data.Models
{
    public class Truck
    {
        public Truck()
        {
            this.ClientsTrucks = new HashSet<ClientTruck>();
        }
        [Key]
        public int Id { get; set; }

        [MinLength(8)]
        [MaxLength(8)]
        [RegularExpression(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$")]
        public string RegistrationNumber { get; set; }

        [Required]
        [MinLength(17)]
        [MaxLength(17)]
        public string VinNumber { get; set; }

        [Range(950, 1420)]
        public int TankCapacity { get; set; }

        [Range(5000, 29000)]
        public int CargoCapacity { get; set; }

        [Required]
        public virtual CategoryType CategoryType { get; set; }

        [Required]
        public virtual MakeType MakeType { get; set; }

        [Required]
        [ForeignKey(nameof(DespatcherId))]
        public int DespatcherId { get; set; }

        public virtual Despatcher Despatcher { get; set; }

        public virtual ICollection<ClientTruck> ClientsTrucks { get; set; }
    }
}
//• Id – integer, Primary Key
//• RegistrationNumber – text with length 8. First two characters are upper letters [A-Z], followed by four digits and the last two characters are upper letters [A-Z] again.
//• VinNumber – text with length 17 (required)
//• TankCapacity – integer in range [950…1420]
//• CargoCapacity – integer in range [5000…29000]
//• CategoryType – enumeration of type CategoryType, with possible values (Flatbed, Jumbo, Refrigerated, Semi) (required)
//• MakeType – enumeration of type MakeType, with possible values (Daf, Man, Mercedes, Scania, Volvo) (required)
//• DespatcherId – integer, foreign key (required)
//• Despatcher – Despatcher 
//• ClientsTrucks – collection of type ClientTruck
