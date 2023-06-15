using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trucks.Data.Models;

namespace Trucks.DataProcessor.ExportDto
{
    public class ExportClientDto
    {
 
        public string Name { get; set; }
  
        public virtual ExportClientTruck[] Trucks { get; set; }
    }
}
