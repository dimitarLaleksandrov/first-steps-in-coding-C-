using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models.Enums;
using Trucks.Data.Models;
using System.Xml.Serialization;

namespace Trucks.DataProcessor.ImportDto
{
    [XmlType("Truck")]
    public class ImportTruckDto
    {
        [XmlElement("RegistrationNumber")]
        [Required]
        [MinLength(8)]
        [MaxLength(8)]
        [RegularExpression(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$")]
        public string RegistrationNumber { get; set; }

        [XmlElement("VinNumber")]
        [Required]
        [MinLength(17)]
        [MaxLength(17)]
        public string VinNumber { get; set; }

        [XmlElement("TankCapacity")]
        [Required]
        [Range(950, 1420)]
        public int TankCapacity { get; set; }

        [XmlElement("CargoCapacity")]
        [Required]
        [Range(5000, 29000)]
        public int CargoCapacity { get; set; }

        [XmlElement("CategoryType")]
        [Required]
        [Range(0, 3)]
        public int CategoryType { get; set; }

        [XmlElement("MakeType")]
        [Required]
        [Range(0, 4)]
        public int MakeType { get; set; }
 
    }
}
