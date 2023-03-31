using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models;

namespace Trucks.Data.Models
{
    public class Client
    {
        public Client()
        {
            this.ClientsTrucks = new HashSet<ClientTruck>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string Nationality { get; set; }

        [Required]
        public string Type { get; set; }

        public virtual ICollection<ClientTruck> ClientsTrucks { get; set;}
    }
}
    //• Id – integer, Primary Key
    //• Name – text with length [3, 40] (required)
    //• Nationality – text with length [2, 40] (required)
    //• Type – text (required)
    //• ClientsTrucks – collection of type ClientTruck
