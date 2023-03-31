using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.DataProcessor.ExportDto
{
    public class ExportTeamJsonDto
    {
        public string Name { get; set; }
        
        public ExportFootballerJsonDto[] Footballers { get; set;}
    }
}
