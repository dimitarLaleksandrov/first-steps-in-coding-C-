using Footballers.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Footballer")]
    public class ImportFootbalerDto
    {
        [Required]
        //[MaxLength(40)]
        //[MinLength(2)]
        [StringLength(40, MinimumLength = 2)]
        [XmlElement("Name")]
        public string Name { get; set; } = null!;

        [Required]
        [XmlElement("ContractStartDate")]
        public string ContractStartDate { get; set; }

        [Required]
        [XmlElement("ContractEndDate")]

        public string ContractEndDate { get; set; }

        [Required]
        [Range(0, 3)]
        [XmlElement("PositionType")]
        public int PositionType { get; set; }

        [Required]
        [Range(0, 4)]
        [XmlElement("BestSkillType")]
        public int BestSkillType { get; set; }
    }
}
