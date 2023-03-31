﻿using Artillery.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto
{
    [XmlType("Manufacturer")]
    public class ImportManufacturersDto
    {
        [XmlElement("ManufacturerName")]
        [Required]
        [MinLength(4)]
        [MaxLength(40)]
        public string ManufacturerName { get; set; }

        [XmlElement("Founded")]
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Founded { get; set; }
    }
}
