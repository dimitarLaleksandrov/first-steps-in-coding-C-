﻿using Footballers.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.Data.Models
{
    public class TeamFootballer
    {
        [Key]
        [ForeignKey(nameof(TeamId))]
        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        [Key]
        [ForeignKey(nameof(FootballerId))]
        public int FootballerId { get; set; }

        public virtual Footballer Footballer { get; set; }
    }
}
    //• TeamId – integer, Primary Key, foreign key (required)
    //• Team – Team
    //• FootballerId – integer, Primary Key, foreign key (required)
    //• Footballer – Footballer