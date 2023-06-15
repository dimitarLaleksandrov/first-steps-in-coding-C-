using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ExportDto
{
    public class ExportsSellerDto
    {
        public string Name { get; set; }

        public string Website { get; set; }

        public ExportJsonBoardgameDto[] Boardgames { get; set; }
    }
}
