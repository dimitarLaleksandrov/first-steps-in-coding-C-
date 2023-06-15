﻿using Boardgames.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class Boardgame
    {
        public Boardgame()
        {
            this.BoardgamesSellers = new HashSet<BoardgameSeller>();
        }
        [Key]
        public int Id { get; set; }

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
        public virtual CategoryType CategoryType { get; set; }

        [Required]
        public string Mechanics { get; set; }

        [Required]
        [ForeignKey(nameof(CreatorId))]
        public int CreatorId { get; set; }

        public virtual Creator Creator { get; set; }

        public virtual ICollection<BoardgameSeller> BoardgamesSellers { get; set; }
    }
}
    //• Id – integer, Primary Key
    //• Name – text with length [10…20] (required)
    //• Rating – double in range [1…10.00] (required)
    //• YearPublished – integer in range [2018…2023] (required)
    //• CategoryType – enumeration of type CategoryType, with possible values (Abstract, Children, Family, Party, Strategy) (required)
    //• Mechanics – text (string, not an array) (required)
    //• CreatorId – integer, foreign key (required)
    //• Creator – Creator
    //• BoardgamesSellers – collection of type BoardgameSeller
