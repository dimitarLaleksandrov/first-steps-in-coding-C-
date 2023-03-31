using Footballers.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.DataProcessor.ExportDto
{
    public class ExportFootballerJsonDto
    {
        public string FootballerName { get; set; }

        public string ContractStartDate { get; set; }

        public string ContractEndDate { get; set; }
        public string BestSkillType { get; set; }
        public string PositionType { get; set; }

       
    }
}
