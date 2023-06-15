using Boardgames.Data.Models.Enums;
using Boardgames.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Boardgame")]
    public class BoardgameDto
    {
        [Required]
        [MinLength(10)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [Range(1, 10.00)]
        public double Rating { get; set; }

        [Required]
        [Range(2018, 2023)]
        public int YearPublished { get; set; }

        [Required]
        public int CategoryType { get; set; }

        [Required]
        public string Mechanics { get; set; } 
    }
}
