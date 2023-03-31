using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ExportDto
{
    [JsonObject("Team")]
    public class ExportTeamDto
    {     
        public string Name { get; set; }
        public IEnumerable<ExportJSONFootballerDto> Footballers { get; set; }

    }
    public class ExportJSONFootballerDto 
    {
        [JsonProperty("FootballerName")]
        public string Name { get; set; } = null!;
      
        public string ContractStartDate { get; set; }
       
        public string ContractEndDate { get; set; }
 
        public string PositionType { get; set; }

        public string BestSkillType { get; set; }
    }

}
